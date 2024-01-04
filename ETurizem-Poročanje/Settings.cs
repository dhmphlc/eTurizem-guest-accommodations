using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Configuration;
using System.Security;
using System.IO;
using System.Security.Cryptography;
using CredentialManagement;
using System.Net;

namespace ETurizem_Poročanje
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private const string Target = "eTurizemDatabaseConnectionCredentials";

        public static void SaveCredentials(string username, string password)
        {
            var credential = new Credential
            {
                Target = Target,
                Username = username,
                Password = password,
                PersistanceType = PersistanceType.LocalComputer,
            };

            credential.Save();
        }

        public static NetworkCredential GetCredentials()
        {
            var credential = new Credential { Target = Target };
            if (credential.Load())
            {
                return new NetworkCredential(credential.Username, credential.Password);
            }

            return null;
        }

        private void shraniBtn_Click(object sender, EventArgs e)
        {
            string host = txtHost.Text;
            string database = txtDatabaseName.Text;
            string usernameString = txtUsername.Text;
            string passwordString = txtPassword.Text;
            bool trustServerCertificate = trustServerCertCheckBox.Checked;
            Properties.Settings.Default.databaseHost = host;
            Properties.Settings.Default.databaseName = database;
            Properties.Settings.Default.trustServerCertificate = trustServerCertificate;
            Properties.Settings.Default.Save();
            SaveCredentials(usernameString, passwordString);

            MainWindow.UpdateConnectionString();

            toolStripStatusLabel1.Text = "Nastavitve uspešno shranjene.";
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            NetworkCredential credentials = Settings.GetCredentials();
            if (credentials != null)
            {
                txtHost.Text = Properties.Settings.Default.databaseHost;
                txtDatabaseName.Text = Properties.Settings.Default.databaseName;
                txtUsername.Text = credentials.UserName;
                txtPassword.Text = credentials.Password;
                trustServerCertCheckBox.Checked = Properties.Settings.Default.trustServerCertificate;
            }
        }
    }
}
