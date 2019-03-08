using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace CyBLE_MTK_Application
{
    public partial class SQLServerConnectionConfigurationDialog : Form
    {

        Configuration AppSettingsconfig = System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.None);
        MTKDB mTKDB;
        MicrosoftSQLDB SQLDB;


        public SQLServerConnectionConfigurationDialog()
        {
            InitializeComponent();

            ReadSQLConnectionConfigurationfromAppConfig(AppSettingsconfig);

        }

        private void ReadSQLConnectionConfigurationfromAppConfig(Configuration config)
        {
            this.DataSourcetextBox.Text = config.AppSettings.Settings["Data Source"].Value;
            this.DataBasetextBox.Text = config.AppSettings.Settings["Initial Catalog"].Value;
            this.PersistSeurityInfocomboBox.Text = config.AppSettings.Settings["Persist Security Info"].Value;
            this.UserIDtextBox.Text = config.AppSettings.Settings["User ID"].Value;
            this.PasswordtextBox.Text = config.AppSettings.Settings["Password"].Value;
            this.ConnectionTimeoutnumericUpDown.Text = config.AppSettings.Settings["Connection Timeout"].Value;

        }

        private void Read_btn_Click(object sender, EventArgs e)
        {
            ReadSQLConnectionConfigurationfromAppConfig(AppSettingsconfig);
        }

        private void SaveExitBtn_Click(object sender, EventArgs e)
        {
            WriteSQLConnectionConfigurationfromAppConfig(AppSettingsconfig);
        }

        private void WriteSQLConnectionConfigurationfromAppConfig(Configuration config)
        {
            config.AppSettings.Settings["Data Source"].Value = this.DataSourcetextBox.Text;
            config.AppSettings.Settings["Initial Catalog"].Value = this.DataBasetextBox.Text;
            config.AppSettings.Settings["Persist Security Info"].Value = this.PersistSeurityInfocomboBox.Text;
            config.AppSettings.Settings["User ID"].Value = this.UserIDtextBox.Text;
            config.AppSettings.Settings["Password"].Value = this.PasswordtextBox.Text;
            config.AppSettings.Settings["Connection Timeout"].Value = this.ConnectionTimeoutnumericUpDown.Text;

            config.Save(ConfigurationSaveMode.Modified);

            System.Configuration.ConfigurationManager.RefreshSection("appSettings");

        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            ReadSQLConnectionConfigurationfromAppConfig(AppSettingsconfig);

            AppSettingsconfig.Save(ConfigurationSaveMode.Modified);

            System.Configuration.ConfigurationManager.RefreshSection("appSettings");

            this.Close();
        }

        private void OpenDB_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SQLDB = new MicrosoftSQLDB();
                SQLDB.TableName = CyBLE_MTK_Application.Properties.Settings.Default.SQLServerDatabaseTableName;
                SQLDB.DoWork(SQLAction.GetRowCnt);
            }
            catch (Exception ex)
            {

                toolStripStatusLabel2.ForeColor = Color.Red;
                toolStripStatusLabel2.Text = ex.ToString();
            }
            if (SQLDB.IsOKOpen)
            {
                toolStripStatusLabel2.ForeColor = Color.Green;
                toolStripStatusLabel2.Text = SQLDB.DataSource + " Opened.";
            }
            else
            {
                toolStripStatusLabel2.ForeColor = Color.Red;
                toolStripStatusLabel2.Text = " No Available DB.";
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
