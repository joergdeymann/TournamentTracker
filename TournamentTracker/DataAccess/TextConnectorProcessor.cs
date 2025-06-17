using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms.Design;
using System.Xml;
using TournamentTracker.Models;
using static System.Windows.Forms.LinkLabel;

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
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(personFileName);
            List<PriceModel> prices = GlobalConfig.PricesFile.FullFilePath().LoadFile().ConvertToPriceModels();
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();
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

                if (cols[4].Length > 0)
                {
                    string[] priceIds = cols[4].Split('|');
                    foreach (string id in priceIds)
                    {
                        tm.Prices.Add(prices.Where(x => x.Id == int.Parse(id)).First());
                    }

                }

                string[] rounds = cols[5].Split('|');
                List<MatchupModel> mm = [];
                foreach (string round in rounds)
                {
                    string[] matchupIds = round.Split('^');
                    foreach(string matchupId in matchupIds)
                    {
                        mm.Add(matchups.Where(x => x.Id == int.Parse(matchupId)).First());
                    }
                    tm.Rounds.Add(mm);

                }

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
                lines.Add($"{ t.Id},{ t.TournamentName },{ t.EntryFee },{ ConvertTeamsToString(t.EnteredTeams) },{ ConvertPricesToString(t.Prices) },{ ConvertRoundsToString(t.Rounds) }");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }


        public static void SaveRoundsToFile(this TournamentModel model, string matchupFilename, string matchupEntryFilename)
        {
            // Loop through Rounds
            // Loop through Matchups
            // Get the Mathupid and save record
            // Loop through Matchup Entries

            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {

                    // Load All Matchups from File
                    // Get the highest ID and Add one
                    // Store ID
                    // Sa the matchup record
                    matchup.SaveMatchupToFile(matchupFilename,matchupEntryFilename);
                    // entryLines.Add(ConvertMacthupsToString(m.Entries));
                }
            }

        }

        private static List<MatchupEntryModel> ConvertToMatchupEntryModels(this List<string> lines)
        {
            // id = 0 TeamCompeting=1 Score = 2 ParentMatchup=3
            List<MatchupEntryModel> output = [];
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                MatchupEntryModel p = new();
                try
                {
                    p.Id = int.Parse(cols[0]);
                    if (int.TryParse(cols[1], out int teamId))
                    {
                        p.TeamCompeting = LookupTeamById(teamId);
                    }
                    else
                    {
                        p.TeamCompeting = null!;
                    }

                    p.Score = double.Parse(cols[2]);
                    
                    if (int.TryParse(cols[3], out int parentId))
                    {
                        p.ParentMatchup = LookupMatchupById(parentId);
                    }
                    else
                    {
                        p.ParentMatchup = null!;
                    }
                    output.Add(p);
                }
                catch
                {
                    Debug.WriteLine("Converting Person Models went wrong:" + cols[0]);
                }

            }

            return output;

        }

        private static List<MatchupEntryModel> ConvertStringToMatchupEntryModels(string input)
        {
            string[] ids = input.Split('|');
            List<MatchupEntryModel> output = [];
            // List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();
            List<string> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile();
            List<string> matchingEntries = [];
            foreach (string id in ids)
            {
                foreach (string entry in entries)
                {
                    string[] cols = entry.Split(',');
                    if (cols[0] == id) // Match the ID
                    {
                        matchingEntries.Add(entry);
                    }

                }
            }
            output = matchingEntries.ConvertToMatchupEntryModels();
            return output;

        }
        private static TeamModel LookupTeamById(int id)
        { 
            List<string> teams= GlobalConfig.TeamFile.FullFilePath().LoadFile();
            foreach (string team in teams)
            {
                string [] cols = team.Split(',');
                if (cols[0] == id.ToString())
                {
                    List<string> matchingTeams= [];
                    matchingTeams.Add(team);
                    return matchingTeams.ConvertToTeamModels(GlobalConfig.PersonFile.FullFilePath()).First();
                }
            }
            return null!;

        }
        private static MatchupModel LookupMatchupById(int id)
        {
            List<string> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile();
            
            foreach(string matchup in matchups)
            {
                string[] cols = matchup.Split(',');

                if (cols[0] == id.ToString())
                {
                    List<string> matchingMatchups = [];
                    matchingMatchups.Add(matchup);
                    return matchingMatchups.ConvertToMatchupModels().First();
                }
            }

            return null!;
        }
        


        public static List<MatchupModel> ConvertToMatchupModels(this List<string> lines)
        {
            //id=0,entries=1 (id|id|id),winner=2, matchaupRound=3
            List<MatchupModel> output = [];
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                MatchupModel p = new();
                try
                {
                    p.Id = int.Parse(cols[0]);

                    p.Entries = ConvertStringToMatchupEntryModels(cols[1]);
                    if (cols[2].Length == 0)
                    {
                        p.Winner = null!;
                    }
                    else
                    {
                        p.Winner = LookupTeamById(int.Parse(cols[2]));
                    }

                    p.MatchupRound = int.Parse(cols[3]);
                    output.Add(p);
                }
                catch
                {
                    Debug.WriteLine("Converting Matchup Models went wrong:" + cols[0]);
                }

            }

            return output;

        }

        public static void SaveMatchupToFile(this MatchupModel matchup, string matchupFilename,string matchupEntryFilename)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();
            int currentId = 1;
            if (matchups.Count > 0)
            {
                currentId = matchups.OrderByDescending(x => x.Id).First().Id + 1;
            }
            matchup.Id = currentId;
            matchups.Add(matchup);

            // Save the Matchup to the file
/*            List<string> lines = [];
            foreach (MatchupModel m in matchups)
            {
                string winner = "";
                if (m.Winner != null)
                {
                    winner = m.Winner.Id.ToString();
                }
                lines.Add($"{m.Id},{""},{winner},{m.MatchupRound}");
            }
            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);
*/
            foreach (MatchupEntryModel entry in matchup.Entries)
            {
                entry.SaveEntryToFile(matchupEntryFilename);
            }

            List<string> lines = [];
            foreach (MatchupModel m in matchups)
            {
                string winner = "";
                if (m.Winner != null)
                {
                    winner = m.Winner.Id.ToString();
                }
                lines.Add($"{m.Id},{ConvertMatchupEntriesToString(m.Entries)},{winner},{m.MatchupRound}");
                // lines.Add($"{m.Id},{""},{winner},{m.MatchupRound}");
            }
            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);
        }

        public static void SaveEntryToFile(this MatchupEntryModel entry, string matchupEntryFilename)
        {
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();
            int currentId = 1;
            if (entries.Count > 0)
            {
                currentId = entries.OrderByDescending(x => x.Id).First().Id + 1;
            }
            entry.Id = currentId;
            entries.Add(entry);

            // Save the entry to the file
            List<string> lines = [];
            foreach (MatchupEntryModel m in entries)
            {
                string parentId = "";
                if (m.ParentMatchup != null)
                {
                    parentId = m.ParentMatchup.Id.ToString();
                }
                string teamCompetingId = "";
                if (m.TeamCompeting != null) 
                {
                    teamCompetingId = m.TeamCompeting.Id.ToString();
                }
                lines.Add($"{m.Id},{teamCompetingId},{m.Score},{parentId}");
            }
            File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(),lines);





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

                output += $"{ ConvertMatchupsToString(round) }|";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertMatchupsToString(List<MatchupModel> matchups)
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
        private static string ConvertMatchupEntriesToString(List<MatchupEntryModel> models)
        {
            if (models.Count == 0) return "";

            string output = "";
            foreach (MatchupEntryModel m in models)
            {
                output += $"{m.Id}|";
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
        public static List<PriceModel> ConvertToPriceModels(this List<string> lines)
        {
            List<PriceModel> output = [];
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
                PersonModel p = new();
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

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string personFileName)
        {
            List<TeamModel> output = [];
            List<PersonModel> persons = personFileName.FullFilePath().LoadFile().ConvertToPersonModels();
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


    }
}
