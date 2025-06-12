using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TournamentTracker.DataAccess;
using System.Data.SqlClient;
using Dapper;


namespace TournamentTracker
{
    public static class GlobalConfig
    {
        public const string PricesFile = "PricesModels.csv";
        public const string PersonFile = "PersonModels.csv";
        public const string TeamFile = "TeamModels.csv";
        public const string TournamentFile = "TournamentModel.csv";
        public const string MatchupFile = "MatchupModel.csv";
        public const string MatchupEntryFile = "MatchupEntryModel.csv";

        public static class CONNECTION 
        {
            public const int SQL = 0;
            public const int LOCAL = 1;
            public const int FILE = 2;
        }


        public static IDataConnection Connections { get; private set; }

        public static bool InitializeConnections(int connectionType)
        {
            bool connection = true;

            switch (connectionType)
            {
                case CONNECTION.SQL:
                    // TODO - Setup connection property
                    SQLConnector sql = new();
                    Connections = sql;
                    break;

                case CONNECTION.FILE:
                    // TODO - Setup TextFile Connection
                    TextConnector text = new();
                    Connections = text;
                    break;
                
                default:
                    connection = false;
                    break;
            }



            return connection;
        }

        public static string ConnectorString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

    }
}
