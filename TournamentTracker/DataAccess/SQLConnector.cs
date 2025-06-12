using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dapper;
// using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using TournamentTracker.Models;
using static TournamentTracker.GlobalConfig;

namespace TournamentTracker.DataAccess
{
    public class SQLConnector : IDataConnection
    {
        private const string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=JDTEST;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;";
        

        public PersonModel CreatePerson(PersonModel model)
        {
            using IDbConnection connection = new SqlConnection(connectionString);
            var p = new DynamicParameters();
            p.Add("@FirstName", model.FirstName);
            p.Add("@LastName", model.LastName);
            p.Add("@EmailAddress", model.EmailAddress);
            p.Add("@CellPhoneNumber", model.CellPhoneNumber);
            p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spPeople_Insert", p, commandType: CommandType.StoredProcedure);
            model.Id = p.Get<int>("@id");

            return model;
        }

        // TODO - Ceate Price: Save to the Databse

        /// <summary>
        ///  Saves a new Price in the Database
        /// </summary>
        /// <param name="model"></param>
        /// <returns>the changed Price Model</returns>
        public PriceModel CreatePrice(PriceModel model)
        {
            using IDbConnection connection = new SqlConnection(connectionString);
            var p = new DynamicParameters();
            p.Add("@PlaceNumber", model.PlaceNumber);
            p.Add("@PlaceName", model.PlaceName);
            p.Add("@PriceAmount", model.PriceAmount, DbType.Currency);
            p.Add("@PricePercentage", model.PricePercentage, DbType.Double);
            p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spPrices_Insert", p, commandType: CommandType.StoredProcedure);
            model.Id = p.Get<int>("@id");

            return model;

        }

        private void InsertTeamPerson(IDbConnection connection, TeamModel model)
        {
            DynamicParameters p;

            foreach(PersonModel tm in model.TeamMembers)
            {
                p = new DynamicParameters();
                p.Add("@TeamId", model.Id);
                p.Add("@PersonId", tm.Id);
                connection.Execute("dbo.spTeamMembers_Insert", p, commandType: CommandType.StoredProcedure);
            }

        }

        public TeamModel CreateTeam(TeamModel model)
        {
            using IDbConnection connection = new SqlConnection(connectionString);
            var p = new DynamicParameters();
            p.Add("@TeamName", model.TeamName);
            p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spTeams_Insert", p, commandType: CommandType.StoredProcedure);
            model.Id = p.Get<int>("@id");
            InsertTeamPerson(connection, model);

            return model;

        }

        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> output;
            using IDbConnection connection = new SqlConnection(connectionString);
            output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
            return output;
        }

        public List<TeamModel> GetTeam_All()
        {
            List<TeamModel> output;
            using IDbConnection connection = new SqlConnection(connectionString);
            output = connection.Query<TeamModel>("dbo.spTeam_GetAll").ToList();

            foreach(TeamModel t in output)
            {
                var p = new DynamicParameters();
                p.Add("@TeamId", t.Id);

                t.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam",p, commandType: CommandType.StoredProcedure).ToList();
            }
            return output;
        }

        private void SaveTournament(IDbConnection connection, TournamentModel model)
        {
            DynamicParameters p = new();
            p.Add("@TournamentName", model.Id);
            p.Add("@EntryFee", model.EntryFee);
            p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spTournament_Insert", p, commandType: CommandType.StoredProcedure);
            model.Id = p.Get<int>("@id");
        }

        private void SaveTournamentPrices(IDbConnection connection, TournamentModel model)
        {
            DynamicParameters p;
            foreach (PriceModel pm in model.Prices)
            {
                p = new();
                p.Add("@TournamentId", model.Id);
                p.Add("@PriceId", pm.Id);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spTournamentPrices_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }
        private void SaveTournamentEntries(IDbConnection connection, TournamentModel model)
        {
            DynamicParameters p;
            foreach (TeamModel tm in model.EnteredTeams)
            {
                p = new();
                p.Add("@TournamentId", model.Id);
                p.Add("@TeamId", tm.Id);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spTournamentEntries_Insert", p, commandType: CommandType.StoredProcedure);
            }

        }
        private void SaveTournamentRounds(IDbConnection connection, TournamentModel model)
        {
            // List<List<MatchupModel>> rounds = model.Rounds;
            // List <MatchupEntryModel> entries = new();
            // Loop Through Rounds
            // Loop through Matchups
            // Save Matchup
            // loop through Entries
            foreach(List<MatchupModel> round in model.Rounds)
            {
                DynamicParameters p;
                foreach (MatchupModel matchup in round)
                {
                    p = new();
                    p.Add("@TournamentId", model.Id);
                    p.Add("@MatchupRound", matchup.MatchupRound);
                    p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                    connection.Execute("dbo.spMatchups_Insert", p, commandType: CommandType.StoredProcedure);
                    matchup.Id = p.Get<int>("@id");

                    foreach(MatchupEntryModel entry in matchup.Entries)
                    {
                        p = new();
                        p.Add("@MatchupId", matchup.Id);

                        if (entry.ParentMatchup == null)
                        {
                            p.Add("@ParentMatchupId", null);
                        }
                        else
                        {
                            p.Add("@ParentMatchupId", entry.ParentMatchup.Id);
                        }

                        if (entry.TeamCompeting == null)
                        {
                            p.Add("@TeamCompetingId", null);

                        } else
                        {
                            p.Add("@TeamCompetingId", entry.TeamCompeting.Id);
                        }
                        
                        p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                        connection.Execute("dbo.spMatchupEntries_Insert", p, commandType: CommandType.StoredProcedure);
                    }
                }
            }

        }
        // public TournamentModel CreateTournament(TournamentModel model)
        public void CreateTournament(TournamentModel model)
        {
            using IDbConnection connection = new SqlConnection(connectionString);
            SaveTournament(connection, model);

            SaveTournamentPrices(connection, model);

            SaveTournamentEntries(connection, model);

            SaveTournamentRounds(connection, model);

            // return model;
        }
    }
}
