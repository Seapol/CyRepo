using System;
using System.Data;
using System.Data.SqlClient;

namespace CyBLE_MTK_Application
{
    public class MTKDB
    {
        private bool isOKOpen;

        public bool IsOKOpen
        {
            get { return isOKOpen; }
            set { isOKOpen = value; }
        }


        private SQLAction sqlAction;

        public SQLAction SQL_Action
        {
            get { return sqlAction; }
            set { sqlAction = value; }
        }


        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        private string sqlstring;

        public string SQLString
        {
            get { return sqlstring; }
            set { sqlstring = value; }
        }

        private string tableName;

        public string TableName
        {
            get { return tableName; }
            set { tableName = value; }
        }

        private string column_list;

        public string Column_list
        {
            get { return column_list; }
            set { column_list = value; }
        }

        private string value_list;

        public string Value_list
        {
            get { return value_list; }
            set { value_list = value; }
        }

        private string datasource;

        public string DataSource
        {
            get { return datasource; }
            set { datasource = value; }
        }



        LogManager Logger = new LogManager();

        public MTKDB(LogManager logger)
        {
            isOKOpen = false;
            datasource = "None";
            Logger = logger;
            InitDB();
        }

        public MTKDB()
        {
            isOKOpen = false;
            datasource = "None";
            InitDB();
        }


        protected void InitDB()
        {
            ConnectionString = "";


            try
            {

                if (OpenConnection() == ConnectionState.Open)
                {
                    isOKOpen = true;
                }
                else
                {
                    isOKOpen = false;
                    datasource = "None";
                }

            }
            catch (Exception ex)
            {
                isOKOpen = false;
                datasource = "None";
                Console.WriteLine("Exception from initDB: \n" + ex.ToString());
            }
        }

        protected virtual void ConnectionUsingConfig(SqlConnection connection)
        {
            return;
        }

        protected void InsertRowToDB(SqlConnection connection)
        {
            int rowCnt = 0;

            sqlstring = "INSERT INTO " + tableName + " (" + column_list + ") " + "VALUES" + " (" + value_list + ")";
            //sqlstring = "INSERT INTO " + tableName +  " VALUES" + " (" + value_list + ")"; 

            if (connection.State == ConnectionState.Open)
            {
                SqlCommand command = new SqlCommand(sqlstring, connection);

                command.CommandText = sqlstring;
                command.CommandTimeout = 3;
                command.CommandType = CommandType.Text;

                try
                {

                    rowCnt = command.ExecuteNonQuery();

                }
                catch (Exception ex)
                {

                    Console.WriteLine("Exception from ExecuteNonQuery: \n" + ex.ToString());
                    Logger.PrintLog(this,"Exception from ExecuteNonQuery: \n" + ex.ToString(),LogDetailLevel.LogRelevant);
                }


            }
            else
            {
                rowCnt = 0;
            }


            if (rowCnt > 0)
            {
                Console.WriteLine("Insert {0} row(s) to {1} successfully.", rowCnt, tableName);
            }
            return;
        }

        protected void GetDBRowCount(SqlConnection connection)
        {
            sqlstring = "Select Count(*) from " + tableName;
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlstring;
            object retVal = command.ExecuteScalar();


            Console.WriteLine("Get DB row count: {0}", retVal);
            Logger.PrintLog(this, $"Workstation ({connection.WorkstationId}) GETs DB row count: <{retVal}> FROM {connection.Database} ({connection.DataSource}).", LogDetailLevel.LogRelevant);

        }

        protected ConnectionState OpenConnection()
        {
            int SleepWaitTime = 300;

            Console.WriteLine("Start Open DB connection...");

            try
            {
                ConnectionUsingConfig();
            }
            catch (Exception)
            {

                throw;
            }
            


            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.InfoMessage += (sender, e) => { Console.WriteLine($"warning or info {e.Message}"); };

                connection.StateChange += (sender, e) => { Console.WriteLine($"DBconnectionStatus: {e.OriginalState} --> {e.CurrentState}"); };


                for (int i = 0; i < 1; i++)
                {

                    try
                    {
                        connection.Open();
                        isOKOpen = true;
                        datasource = connection.DataSource;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Fail to open DB connection. Timeout: {0} sec.", connection.ConnectionTimeout);
                        Logger.PrintLog(this, $"Fail to open DB {connection.Database} ({connection.DataSource}) connection. Timeout: {connection.ConnectionTimeout} sec.", LogDetailLevel.LogRelevant);
                        isOKOpen = false;
                        datasource = "None";
                    }


                    switch (connection.State)
                    {
                        case ConnectionState.Closed:
                            System.Threading.Thread.Sleep(SleepWaitTime);
                            Console.WriteLine("Open {0} Failure", this.GetType().ToString().Substring(22));
                            Logger.PrintLog(this, $"Open {this.GetType().ToString().Substring(22)} {connection.Database} ({connection.DataSource}) Failure.", LogDetailLevel.LogRelevant);

                            break;
                        case ConnectionState.Open:
                            Console.WriteLine("Open {0} Successfully", this.GetType().ToString().Substring(22));
                            Logger.PrintLog(this, $"Open {this.GetType().ToString().Substring(22)} {connection.Database} ({connection.DataSource}) Successfully.", LogDetailLevel.LogRelevant);

                            return connection.State;
                        case ConnectionState.Connecting:
                            Console.WriteLine("Wait {0} for {1} msecs because of {2}", this.GetType().ToString().Substring(22), SleepWaitTime,connection.State);
                            System.Threading.Thread.Sleep(SleepWaitTime);
                            break;
                        case ConnectionState.Executing:
                            Console.WriteLine("Wait {0} for {1} msecs because of {2}", this.GetType().ToString().Substring(22), SleepWaitTime, connection.State);
                            System.Threading.Thread.Sleep(SleepWaitTime);
                            break;
                        case ConnectionState.Fetching:
                            Console.WriteLine("Wait {0} for {1} msecs because of {2}", this.GetType().ToString().Substring(22), SleepWaitTime, connection.State);
                            System.Threading.Thread.Sleep(SleepWaitTime);
                            break;
                        case ConnectionState.Broken:
                            return connection.State;
                        default:
                            break;
                    }

                    ConnectionUsingConfig(connection);

                }


                return connection.State;
            }
        }

        public void DoWork(SQLAction sqlAction)
        {
            int WaitSleepTime = 1;

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.InfoMessage += (sender, e) => { Console.WriteLine($"warning or info {e.Message}"); };

                connection.StateChange += (sender, e) => { Console.WriteLine($"DBconnectionStatus: {e.OriginalState} --> {e.CurrentState}"); };


                for (int i = 0; i < 100; i++)
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        isOKOpen = false;
                        datasource = "None";
                        System.Threading.Thread.Sleep(WaitSleepTime);
                        connection.Open();
                    }
                    else
                    {
                        isOKOpen = true;
                        datasource = connection.DataSource;
                        break;
                    }
                }

                switch (sqlAction)
                {
                    case SQLAction.InsertRow:
                        InsertRowToDB(connection);
                        break;
                    case SQLAction.GetRowCnt:
                        GetDBRowCount(connection);
                        break;
                    case SQLAction.Nothing:
                        break;
                    default:
                        break;
                }
            }


        }

        protected virtual void ConnectionUsingConfig()
        {
        }

        protected void CheckConnectionStatus()
        {
        }
    }
}