using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ETurizem_Poročanje
{
    public partial class NastavitveneEnote : Form
    {
        public NastavitveneEnote()
        {
            InitializeComponent();
        }

        private void accommodation_unitsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accommodation_unitsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eturizemDataSet);
        }

        private void NastavitveneEnote_Load(object sender, EventArgs e)
        {
            DataColumn facilityTitleColumn = new DataColumn("facility_title", typeof(string));
            eturizemDataSet.accommodation_units.Columns.Add(facilityTitleColumn);
            ReloadGridView();
        }

        public void ReloadGridView()
        {
            accommodation_unitsDataGridView.AutoGenerateColumns = true;
            accommodation_unitsDataGridView.Columns["facility_title"].HeaderText = "Nastanitveni obrat"; // set column header text
            accommodation_unitsDataGridView.Columns["facility_title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // set column to size fill
            accommodation_unitsDataGridView.Columns["facility_title"].FillWeight = 50; // set the weight of the column to 50 of something no idea
            try
            {
                this.accommodation_unitsTableAdapter.Fill(this.eturizemDataSet.accommodation_units);
                string connectionString = MainWindow.GetConnectionString();
                string q = @"SELECT unitRow.accommodation_facility, facilityRow.title AS FacilityTitle 
                         FROM accommodation_units AS unitRow 
                         JOIN accommodation_facilities AS facilityRow ON unitRow.accommodation_facility = facilityRow.id";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = new SqlCommand(q, connection);
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                Dictionary<int, string> facilityMapping = new Dictionary<int, string>();

                while (reader.Read())
                {
                    int accommodationFacilityId = reader.GetInt32(0);
                    string facilityTitle = reader.GetString(1);

                    if (!facilityMapping.ContainsKey(accommodationFacilityId))
                    {
                        facilityMapping.Add(accommodationFacilityId, facilityTitle);
                    }
                }

                reader.Close();
                connection.Close();

                foreach (DataRow row in eturizemDataSet.accommodation_units.Rows)
                {
                    int accommodationUnitId = (int)row["accommodation_facility"];

                    if (facilityMapping.ContainsKey(accommodationUnitId))
                    {
                        row["facility_title"] = facilityMapping[accommodationUnitId].ToString();
                    }
                }
                accommodation_unitsDataGridView.DataSource = eturizemDataSet.accommodation_units;
                addUnitButton.Enabled = true;
                deleteUnitBtn.Enabled = true;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 18456 && ex.State == 1) // Error 18456: Login failed for user
                {
                    MessageBox.Show("Prijava navedenega uporabnika ni uspela.", "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    addUnitButton.Enabled = false;
                    deleteUnitBtn.Enabled = false;
                }
                else
                {
                    MessageBox.Show($"SQL Server Napaka: {ex.Message}", "SQL Server Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    addUnitButton.Enabled = false;
                    deleteUnitBtn.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Napaka: {ex.Message}", "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                addUnitButton.Enabled = false;
                deleteUnitBtn.Enabled = false;
            }
        }

        private void addUnitButton_Click(object sender, EventArgs e)
        {
            DodajEnoto dodajEnoto = new DodajEnoto();
            dodajEnoto.ShowDialog();
            ReloadGridView();
        }

        private void accommodation_unitsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow clickedRow = ((DataRowView)accommodation_unitsDataGridView.Rows[e.RowIndex].DataBoundItem).Row;
            DodajEnoto dodEno = new DodajEnoto(this, true, clickedRow);
            dodEno.ShowDialog();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (accommodation_unitsBindingSource != null && accommodation_unitsDataGridView.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Ali ste prepričani, da želite izbrisati izbrane enote?", "Opozorilo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        foreach (DataGridViewRow selectedRow in accommodation_unitsDataGridView.SelectedRows)
                        {
                            int unitId = Convert.ToInt32(selectedRow.Cells["dataGridViewTextBoxColumn1"].Value);
                            DeleteUnit(unitId);
                        }
                        ReloadGridView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Prišlo je do napake pri brisanju: {ex.Message}", "Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Prosim izberite vsaj eno vrstico (za izbiro kliknite ob levi strani vrstice).", "Error");
            }
            ReloadGridView();
        }

        private void DeleteUnit(int unitId)
        {
            try
            {
                string connectionString = MainWindow.GetConnectionString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("DELETE FROM dbo.accommodation_units WHERE id = @UnitId", connection))
                    {
                        command.Parameters.AddWithValue("@UnitId", unitId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    throw new InvalidOperationException("Enote ne morete odstraniti, preden ne odstranite povezanih rezervacij.");
                }
                else
                {
                    // Rethrow the exception if it's unexpected
                    throw;
                }
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            ReloadGridView();
        }
    }
}
