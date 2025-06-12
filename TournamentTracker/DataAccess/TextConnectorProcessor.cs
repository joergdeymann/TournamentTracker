using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using TournamentTracker.Models;

namespace TournamentTracker.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        // PricweModels.csv
        public static string FullFilePath(this string filename)
        {
            // c:\PROG\datentext\{filename}
            // return $"{ConfigurationManager.AppSettings["filePath"]}\\{filename}";
            return $"c:\\PROG\\datentext\\{filename}";

        }

        public static List<string> LoadFile(this string filename)
        {
            if (!File.Exists(filename))
            {
                return [];
            }
            return File.ReadAllLines(filename).ToList();

        }

        public static List<PriceModel> ConvertToPriceModels(this List<string> lines)
        {
            List<PriceModel> output =[];
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                PriceModel p = new();
                try
                {
                    p.Id = int.Parse(cols[0]);
                    p.PlaceNumber = int.Parse(cols[1]);
                    p.PlaceName = cols[2];
                    p.PriceAmount = decimal.Parse(cols[3]);
                    p.PricePercentage = double.Parse(cols[4]);
                    output.Add(p);
                }
                catch
                {
                    Debug.WriteLine("Converting Price Models went wrong:" + cols[0]);
                }

            }

            return output;

        }

        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = [];
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                PersonModel p = new ();
                try
                {
                    p.Id = int.Parse(cols[0]);
                    p.FirstName = cols[1];
                    p.LastName = cols[2];
                    p.EmailAddress = cols[3];
                    p.CellPhoneNumber = cols[4];
                    output.Add(p);
                }
                catch
                {
                    Debug.WriteLine("Converting Person Models went wrong:" + cols[0]);
                }

            }

            return output;

        }

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines,string personFileName)
        {
            List<TeamModel> output = [];
            List <PersonModel> persons = personFileName.FullFilePath().LoadFile().ConvertToPersonModels();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                TeamModel p = new();
                try
                {
                    p.Id = int.Parse(cols[0]);
                    p.TeamName = cols[1];

                    string[] personIds = cols[2].Split('|');
                    foreach (string personId in personIds)
                    {
                        p.TeamMembers.Add(persons.Where(x => x.Id == int.Parse(personId)).First());
                    }


                    output.Add(p);
                }
                catch
                {
                    Debug.WriteLine("Converting Team Models went wrong:" + cols[0]);
                }

            }

            return output;

        }



        public static List<TournamentModel> ConvertToTournamentModels(
            this List<string> lines,
            string teamFileName,
            string personFileName,
            string priceFileName
        )
        {
            //id,
            //Torunament Name,
            //EntreeFee,
            //List of EnteredTeams (id|id|id),
            //List of Prices (id|id|id)
            //Rounds (id^id^id|id^id^id|id^id^id)
            List<TournamentModel> output = [];
            List<TeamModel> teams = teamFileName.FullFilePath().LoadFile().ConvertToTeamModels(personFileName);
            List<PriceModel> prices = priceFileName.FullFilePath().LoadFile().ConvertToPriceModels();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                TournamentModel tm = new()
                {
                    Id = int.Parse(cols[0]),
                    TournamentName = cols[1],
                    EntryFee = decimal.Parse(cols[2])
                };
                string[] teamIds = cols[3].Split('|');
                foreach (string id in teamIds)
                {
                    tm.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());
                }
                string[] priceIds = cols[4].Split('|');
                foreach(string id in priceIds)
                {
                    tm.Prices.Add(prices.Where(x => x.Id == int.Parse(id)).First());
                }
                // TODO - Capture Rounds Information

                output.Add(tm);

            }
            return output;

        }

        public static void SaveToPriceFile(this List<PriceModel> models, string filename)
        {
            List<string> lines = [];
            foreach (PriceModel p in models)
            {
                lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PriceAmount},{p.PricePercentage}");
            }
            File.WriteAllLines(filename.FullFilePath(), lines);

        }

        public static void SaveToPersonFile(this List<PersonModel> models, string filename)
        {
            List<string> lines = [];
            foreach (PersonModel p in models)
            {
                lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.CellPhoneNumber}");
            }
            File.WriteAllLines(filename.FullFilePath(), lines);
        }

        public static void SaveToTeamFile(this List<TeamModel> models, string fileName)
        {
            List<string> lines = [];
            foreach (TeamModel t in models)
            {
                lines.Add($"{t.Id},{t.TeamName},{ConvertPersonsToString(t.TeamMembers)}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        //id,
        //Torunament Name,
        //EntreeFee,
        //List of EnteredTeams (id|id|id),
        //List of Prices (id|id|id)
        public static void SaveToTournamentFile(this List<TournamentModel> models, string fileName)
        {
            List<string> lines = [];
            foreach (TournamentModel t in models)
            {
                lines.Add($@"
                    { t.Id},
                    { t.TournamentName },
                    { t.EntryFee },
                    { ConvertTeamsToString(t.EnteredTeams) },
                    { ConvertPricesToString(t.Prices) },
                    { ConvertRoundsToString(t.Rounds) }
                ");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        /**************************************************************************************************************
         * Converts
         **************************************************************************************************************/
        //Rounds (id^id^id|id^id^id|id^id^id)
        private static string ConvertRoundsToString(List<List<MatchupModel>> rounds)
        {
            if (rounds.Count == 0) return "";

            string output = "";
            foreach (List<MatchupModel> round in rounds)
            {

                output += $"{ ConvertMacthupsToString(round) }|";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertMacthupsToString(List<MatchupModel> matchups)
        {
            string output = "";
            if (matchups.Count == 0) return "";
            foreach(MatchupModel m  in matchups)
            {
                output += $"{m.Id}^";
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }
        private static string ConvertPricesToString(List<PriceModel> prices)
        {
            if (prices.Count == 0) return "";

            string output = "";
            foreach (PriceModel price in prices)
            {
                output += $"{price.Id}|";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }
        private static string ConvertPersonsToString(List<PersonModel> persons)
        {
            if (persons.Count == 0) return "";

            string output = "";
            foreach (PersonModel person in persons)
            {
                output += $"{person.Id}|";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }
        private static string ConvertTeamsToString(List<TeamModel> teams)
        {
            if (teams.Count == 0) return "";

            string output = "";
            foreach (TeamModel m in teams)
            {
                output += $"{m.Id}|";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }

    }
}
