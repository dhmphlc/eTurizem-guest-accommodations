using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETurizem_Poročanje
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenForm<T>() where T : Form, new()
        {
            foreach (Form openForm in this.MdiChildren)
            {
                openForm.Close();
            }
            T newForm = new T();
            newForm.MdiParent = this;
            newForm.Dock = DockStyle.Fill;
            newForm.Show();
        }

        private void openFacilitiesBtn_Click(object sender, EventArgs e)
        {
            OpenForm<NastavitveniObrati>();
        }

        private void openUnitsBtn_Click(object sender, EventArgs e)
        {
            OpenForm<NastavitveneEnote>();
        }

        private void openGuestBookBtn_Click(object sender, EventArgs e)
        {
            OpenForm<KnjigaGostov>();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            OpenForm<Settings>();
        }

        private void appLabel_Click(object sender, EventArgs e)
        {
            foreach (Form openForm in this.MdiChildren)
            {
                openForm.Close();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            UpdateConnectionString();
            Console.WriteLine(GetConnectionString());
        }

        public static void UpdateConnectionString()
        {
            string originalConnectionString = Properties.Settings.Default.eTurizemConnectionString;

            NetworkCredential credentials = Settings.GetCredentials();
            if (credentials != null)
            {
                string dataSource = Properties.Settings.Default.databaseHost;
                string initialCatalog = Properties.Settings.Default.databaseName;
                bool trustservercertificate = Properties.Settings.Default.trustServerCertificate;
                string connectionStringWithCredentials = $"{originalConnectionString};Data Source={dataSource};Initial Catalog={initialCatalog};TrustServerCertificate={trustservercertificate}; User ID={credentials.UserName};Password={credentials.Password};";

                Properties.Settings.Default.eTurizemConnectionString = connectionStringWithCredentials;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Podatki za prijavo niso bili najdeni v Upravitelju poverilnic. \nDodajte jih v nastavitvah programa.", "Opozorilo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static string GetConnectionString()
        {
            return Properties.Settings.Default.eTurizemConnectionString;
        }
    }
}
