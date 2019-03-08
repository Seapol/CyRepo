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

        public MicrosoftSQLDB() : base()
        {

        }

        protected override void ConnectionUsingConfig(SqlConnection connection)
        {

            switch (connection.State)
            {
                case ConnectionState.Closed:
                    ConnectionUsingAppConfig();
                    //ConnectionUsingJsonConfig();
                
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
                    //ConnectionUsingLocalConfig();
                    Console.WriteLine("Try " + ConnectionString + " because DBconnection is unreachable or broken.");
                    break;
                default:
                    break;
            }


        }

        protected override void ConnectionUsingConfig()
        {

            ConnectionUsingAppConfig();
            //ConnectionUsingJsonConfig();


        }

        private void ConnectionUsingJsonConfig()
        {
            var configurationBuilder = new ConfigurationBuilder().AddJsonFile("connectionString.json");
            IConfiguration config = configurationBuilder.Build();
            ConnectionString = config["Data:DefaultConnection:SQLConnectionString"];
        }

        private void ConnectionUsingAppConfig()
        {
            System.Configuration.Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.None);



            ConnectionString = "Data Source=" + config.AppSettings.Settings["Data Source"].Value + ";" +
                                "Initial Catalog=" + config.AppSettings.Settings["Initial Catalog"].Value + ";" +
                                "Persist Security Info=" + config.AppSettings.Settings["Persist Security Info"].Value + ";" +
                                "User ID=" + config.AppSettings.Settings["User ID"].Value + ";" +
                                "Password=" + config.AppSettings.Settings["Password"].Value + ";" +
                                "Connection Timeout=" + config.AppSettings.Settings["Connection Timeout"].Value;

        }
    }
}