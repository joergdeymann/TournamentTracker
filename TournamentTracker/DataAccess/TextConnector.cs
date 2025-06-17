using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentTracker.Models;
using TournamentTracker.DataAccess.TextHelpers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.Diagnostics;


namespace TournamentTracker.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PricesFile = "PricesModels.csv";
        private const string PersonFile = "PersonModels.csv";
        private const string TeamFile = "TeamModels.csv";
        private const string TournamentFile = "TournamentModel.csv";
        private const string MatchupFile = "MatchupModel.csv";
        private const string MatchupEntryFile = "MatchupEntryModel.csv";



        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> persons = PersonFile.FullFilePath().LoadFile().ConvertToPersonModels();
            // Find max Id
            int currentId = 1;
            if (persons.Count > 0)
            {
                currentId = persons.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            // Add the new Record  with the new ID 
            persons.Add(model);

            // Convert the Prices to List

            // Save the list to the textfile
            persons.SaveToPersonFile(PersonFile);

            return model;
        }

        //TODO - Wire up Create Price for Textfiles
        /// <summary>
        /// Creates a connection to an Textfile
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public PriceModel CreatePrice(PriceModel model)
        {
            //var config = new ConfigurationBuilder()
            //    .SetBasePath(AppContext.BaseDirectory)
            //    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            //    .Build();

            //string title = config["appSettings:filepath"];
            //Debug.WriteLine(title);

            List<PriceModel> prices = PricesFile.FullFilePath().LoadFile().ConvertToPriceModels();
            // Find max Id
            int currentId = 1;
            if (prices.Count > 0)
            {
                currentId = prices.OrderByDescending(x => x.Id).First().Id + 1;
            }
            
            model.Id = currentId;

            // Add the new Record  with the new ID 
            prices.Add(model);

            // Convert the Prices to List

            // Save the list to the textfile
            prices.SaveToPriceFile(PricesFile);

            return model;
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PersonFile);
            int currentId = 1;

            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            teams.Add(model);

            teams.SaveToTeamFile(TeamFile);
            
            return model;
        }

        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = TournamentFile
                .FullFilePath()
                .LoadFile()
                .ConvertToTournamentModels(TeamFile,PersonFile,PricesFile);

            int currentId = 1;
            if (tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;
            model.SaveRoundsToFile(MatchupFile,MatchupEntryFile);
            tournaments.Add(model);
            tournaments.SaveToTournamentFile(TournamentFile);
        }

        public List<PersonModel> GetPerson_All()
        {
            return PersonFile.FullFilePath().LoadFile().ConvertToPersonModels(); // PersonFile
        }

        public List<TeamModel> GetTeam_All()
        {
            return TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PersonFile);
        }

        public List<TournamentModel> GetTournament_All()
        {
            return TournamentFile
                .FullFilePath()
                .LoadFile()
                .ConvertToTournamentModels(TeamFile, PersonFile, PricesFile);
        }

    }
}
