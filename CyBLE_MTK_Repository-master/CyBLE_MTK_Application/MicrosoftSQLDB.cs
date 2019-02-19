using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using static System.Console;

namespace CyBLE_MTK_Application
{
    public class MicrosoftSQLDB: MTKDB
    {
        public MicrosoftSQLDB(LogManager logger) : base(logger)
        {

        }

        protected override void ConnectionUsingConfig(SqlConnection connection)
        {

            switch (connection.State)
            {
                case ConnectionState.Closed:
                    ConnectionUsingDefaultConfig();
                    break;
                case ConnectionState.Open:
                    Console.WriteLine("Already Open " + ConnectionString);
                    break;
                case ConnectionState.Connecting:
                    Console.WriteLine("Is trying " + ConnectionString);
                    break;
                case ConnectionState.Executing:
                    break;
                case ConnectionState.Fetching:
                    break;
                case ConnectionState.Broken:
                    ConnectionUsingLocalConfig();
                    Console.WriteLine("Try " + ConnectionString + " because DBconnection is unreachable or broken.");
                    break;
                default:
                    break;
            }


        }

        protected override void ConnectionUsingConfig()
        {

            ConnectionUsingDefaultConfig();


        }

        private void ConnectionUsingDefaultConfig()
        {
            var configurationBuilder = new ConfigurationBuilder().AddJsonFile("connectionString.json");
            IConfiguration config = configurationBuilder.Build();
            ConnectionString = config["Data:DefaultConnection:SQLConnectionString"];
        }

        private void ConnectionUsingLocalConfig()
        {
            var configurationBuilder = new ConfigurationBuilder().AddJsonFile("connectionString.json");
            IConfiguration config = configurationBuilder.Build();
            ConnectionString = config["Data:LocalConnection:SQLConnectionString"];
        }
    }
}