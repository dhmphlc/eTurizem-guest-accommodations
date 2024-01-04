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
    public partial class NastavitveniObrati : Form
    {
        public NastavitveniObrati()
        {
            InitializeComponent();
        }

        private void NastavitveniObrati_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void accommodation_facilitiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accommodation_facilitiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eturizemDataSet);
        }

        private void addUnitButton_Click(object sender, EventArgs e)
        {
            DodajObrat dodajObrat = new DodajObrat();
            dodajObrat.ShowDialog();
            RefreshDataGridView();
        }

        public void RefreshDataGridView()
        {
            try
            {
                this.accommodation_facilitiesTableAdapter.Fill(this.eturizemDataSet.accommodation_facilities);
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

        private void accommodation_facilitiesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow clickedRow = ((DataRowView)accommodation_facilitiesDataGridView.Rows[e.RowIndex].DataBoundItem).Row;
            DodajObrat dodObrt = new DodajObrat(this, true, clickedRow);
            dodObrt.ShowDialog();
        }

        private void deleteUnitBtn_Click(object sender, EventArgs e)
        {
            if (accommodation_facilitiesDataGridView.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Ali ste prepričani, da želite izbrisati izbrane obrate?", "Opozorilo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        foreach (DataGridViewRow selectedRow in accommodation_facilitiesDataGridView.SelectedRows)
                        {
                            int facilityId = Convert.ToInt32(selectedRow.Cells["dataGridViewTextBoxColumn1"].Value);
                            DeleteFacility(facilityId);
                        }
                        RefreshDataGridView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Prišlo je do napake: {ex.Message}", "Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Prosim izberite vsaj eno vrstico.", "Error");
            }
        }

        private void DeleteFacility(int facilityId)
        {
            try
            {
                string connectionString = MainWindow.GetConnectionString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("DELETE FROM dbo.accommodation_facilities WHERE id = @FacilityId", connection))
                    {
                        command.Parameters.AddWithValue("@FacilityId", facilityId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    throw new InvalidOperationException("Obrata ne morete odstraniti, preden ne odstranite povezanih enot.");
                }
                else
                {
                    throw;
                }
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
    }
}
