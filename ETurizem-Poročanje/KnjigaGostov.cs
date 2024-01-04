using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ETurizem_Poročanje
{
    public partial class KnjigaGostov : Form
    {
        DodajGosta dodajGostaInstance = new DodajGosta();
        public KnjigaGostov()
        {
            InitializeComponent();
        }

        private void guest_bookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.guest_bookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eturizemDataSet);
        }

        private void KnjigaGostov_Load(object sender, EventArgs e)
        {
            DataColumn unitTitleColumn = new DataColumn("unit_title", typeof(string));
            eturizemDataSet.guest_book.Columns.Add(unitTitleColumn);
            RefreshDataGridView();
            ResizeDataGridView();
        }

        public void ResizeDataGridView()
        {
            for (int i = 0; i < guest_bookDataGridView.ColumnCount; i++)
            {
                guest_bookDataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        public void RefreshDataGridView()
        {
            guest_bookDataGridView.AutoGenerateColumns = true;
            guest_bookDataGridView.Columns["unit_title"].HeaderText = "Nastanitvena enota";
            try
            {
                this.guest_bookTableAdapter.Fill(this.eturizemDataSet.guest_book);
                string connectionString = MainWindow.GetConnectionString();
                string q = @"SELECT guestRow.accommodation_unit, unitRow.title AS UnitTitle 
                             FROM guest_book AS guestRow 
                             JOIN accommodation_units AS unitRow ON guestRow.accommodation_unit = unitRow.id;";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = new SqlCommand(q, connection);
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                Dictionary<int, string> unitMapping = new Dictionary<int, string>();

                while (reader.Read())
                {
                    int accommodationFacilityId = reader.GetInt32(0);
                    string unitTitle = reader.GetString(1);

                    if (!unitMapping.ContainsKey(accommodationFacilityId))
                    {
                        unitMapping.Add(accommodationFacilityId, unitTitle);
                    }
                }

                reader.Close();
                connection.Close();


                foreach (DataRow row in eturizemDataSet.guest_book.Rows)
                {
                    int accommodationUnitId = (int)row["accommodation_unit"];

                    if (unitMapping.ContainsKey(accommodationUnitId))
                    {
                        row["unit_title"] = unitMapping[accommodationUnitId].ToString();
                    }
                }
                guest_bookDataGridView.DataSource = eturizemDataSet.guest_book;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 18456 && ex.State == 1) // Error 18456: Login failed for user
                {
                    MessageBox.Show("Prijava navedenega uporabnika ni uspela.", "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    addGuestButton.Enabled = false;
                    cancelGuestBtn.Enabled = false;
                    btnExportGuests.Enabled = false;
                }
                else
                {
                    MessageBox.Show($"SQL Server Napaka: {ex.Message}", "SQL Server Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    addGuestButton.Enabled = false;
                    cancelGuestBtn.Enabled = false;
                    btnExportGuests.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Napaka: {ex.Message}", "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                addGuestButton.Enabled = false;
                cancelGuestBtn.Enabled = false;
                btnExportGuests.Enabled = false;
            }
        }

        private void addGuestButton_Click(object sender, EventArgs e)
        {
            DodajGosta dg = new DodajGosta();
            dg.FormBorderStyle = FormBorderStyle.FixedSingle; // disable dialog resize
            dg.ShowDialog();
            RefreshDataGridView();
        }

        private void guest_bookDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int canceledValue = Convert.ToInt32(guest_bookDataGridView.Rows[e.RowIndex].Cells["canceled"].Value);
            if(canceledValue != 1)
            {
                DataRow clickedRow = ((DataRowView)guest_bookDataGridView.Rows[e.RowIndex].DataBoundItem).Row;
                DodajGosta dodObrt = new DodajGosta();
                dodObrt.LoadGuest(this, true, clickedRow);
                dodObrt.ShowDialog();
            }
        }

        private void guest_bookDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (guest_bookDataGridView.Columns[e.ColumnIndex].Name == "dataGridViewTextBoxColumn13" && e.RowIndex >= 0)
            {
                int ttaxTypeValue = Convert.ToInt32(guest_bookDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn13"].Value);
                string name = dodajGostaInstance.GetTaksaImeByID(ttaxTypeValue);
                e.Value = name;
            }

            if (guest_bookDataGridView.Columns[e.ColumnIndex].Name == "dataGridViewTextBoxColumn7" && e.RowIndex >= 0)
            {
                char docCharValue = Convert.ToChar(guest_bookDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn7"].Value);
                string name = dodajGostaInstance.GetDokumentImeByChar(docCharValue);
                e.Value = name;
            }

            if (guest_bookDataGridView.Columns[e.ColumnIndex].Name == "dataGridViewTextBoxColumn4" && e.RowIndex >= 0)
            {
                string countryValue = Convert.ToString(guest_bookDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn4"].Value);
                string name = dodajGostaInstance.GetCountryNameByID(countryValue);
                e.Value = name;
            }

        }

        private void guest_bookDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (guest_bookDataGridView.SelectedRows.Count > 0)
            {
                cancelGuestBtn.Enabled = true;
                btnExportGuests.Enabled = true;
            }
            else
            {
                cancelGuestBtn.Enabled = false;
                btnExportGuests.Enabled = false;
            }
        }

        private void cancelGuestBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ste prepričani, da želite preklicati tega gosta? To dejanje ni mogoče razveljaviti.", "Potrditev preklica", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow selectedRow in guest_bookDataGridView.SelectedRows)
                {
                    DataRowView dataRowView = (DataRowView)selectedRow.DataBoundItem;
                    DataRow selectedDataRow = dataRowView.Row;
                    selectedDataRow["canceled"] = 1;
                    selectedRow.DefaultCellStyle.BackColor = Color.LightGray;
                    selectedRow.ReadOnly = true;
                }
                this.guest_bookTableAdapter.Update(this.eturizemDataSet.guest_book);
            }
        }

        private void guest_bookDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int canceledValue = Convert.ToInt32(guest_bookDataGridView.Rows[e.RowIndex].Cells["canceled"].Value);
            if (canceledValue == 1)
            {
                guest_bookDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
                guest_bookDataGridView.Rows[e.RowIndex].ReadOnly = true;
            }
            int ajpesStateValue = Convert.ToInt32(guest_bookDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn15"].Value);

            if(ajpesStateValue == 1)
            {
                guest_bookDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }

        private void btnExportGuests_Click(object sender, EventArgs e)
        {
            var selectedRows = guest_bookDataGridView.SelectedRows;

            if (selectedRows.Count == 0)
            {
                MessageBox.Show("No rows selected for export.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create the XML document
            XDocument xmlDocument = new XDocument(
                new XElement("knjigaGostov",
                    selectedRows.Cast<DataGridViewRow>().Select(row =>
                    {
                        int accommodationUnitId = Convert.ToInt32(row.Cells["dataGridViewTextBoxColumn14"].Value);
                        var facilityInfo = GetAccommodationFacilityInfo(accommodationUnitId);

                        //yyyy-MM-DDThh:mm:ss
                        DateTime datumPrihoda = Convert.ToDateTime(row.Cells["dataGridViewTextBoxColumn9"].Value);
                        DateTime uraPrihoda = Convert.ToDateTime(row.Cells["dataGridViewTextBoxColumn10"].Value);
                        DateTime datumOdhoda = Convert.ToDateTime(row.Cells["dataGridViewTextBoxColumn11"].Value);
                        DateTime uraOdhoda = Convert.ToDateTime(row.Cells["dataGridViewTextBoxColumn12"].Value);
                        string formattedCasPrihoda = datumPrihoda.ToString("yyyy-MM-dd") + "T" + uraPrihoda.ToString("hh:mm:ss");
                        string formattedCasOdhoda = datumOdhoda.ToString("yyyy-MM-dd") + "T" + uraOdhoda.ToString("hh:mm:ss");

                        return new XElement("row",
                            new XAttribute("idNO", facilityInfo.IdNO),
                            new XAttribute("zst", row.Cells["dataGridViewTextBoxColumn1"].Value),
                            new XAttribute("ime", row.Cells["dataGridViewTextBoxColumn2"].Value),
                            new XAttribute("pri", row.Cells["dataGridViewTextBoxColumn3"].Value),
                            new XAttribute("sp", row.Cells["dataGridViewTextBoxColumn6"].Value),
                            new XAttribute("dtRoj", row.Cells["dataGridViewTextBoxColumn5"].Value),
                            new XAttribute("drzava", row.Cells["dataGridViewTextBoxColumn4"].Value),
                            new XAttribute("vrstaDok", row.Cells["dataGridViewTextBoxColumn7"].Value),
                            new XAttribute("idStDok", row.Cells["dataGridViewTextBoxColumn8"].Value),
                            new XAttribute("casPrihoda", formattedCasPrihoda),
                            new XAttribute("casOdhoda", formattedCasOdhoda),
                            new XAttribute("status", row.Cells["canceled"].Value),
                            new XAttribute("ttObracun", row.Cells["dataGridViewTextBoxColumn13"].Value),
                            new XAttribute("ttVisina", facilityInfo.TaxPrice)
                        );
                    }
                    )
                )
            );

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "XML files (*.xml)|*.xml",
                DefaultExt = "xml",
                AddExtension = true,
                FileName = "guest-book-export-" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm") + ".xml"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Save the XML document to the selected file path
                string filePath = saveFileDialog.FileName;
                xmlDocument.Save(filePath);

                MessageBox.Show($"Izbrane vrstice so bile izvožene v {filePath}.", "Uspešen izvoz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    string updateQuery = "UPDATE guest_book SET ajpes_sending_state = 1 WHERE id = @Id;";
                    string connectionString = MainWindow.GetConnectionString();
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        {
                            foreach (DataGridViewRow row in selectedRows)
                            {
                                int id = Convert.ToInt32(row.Cells["dataGridViewTextBoxColumn1"].Value);

                                updateCommand.Parameters.Clear();
                                updateCommand.Parameters.AddWithValue("@Id", id);
                                updateCommand.ExecuteNonQuery();
                            }
                        }
                    }
                    RefreshDataGridView();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Database update error: {ex.Message}");
                }
            }
        }

        private AccommodationFacilityInfo GetAccommodationFacilityInfo(int accommodationUnitId)
        {
            string connectionString = MainWindow.GetConnectionString();
            string query = $"SELECT id, ttax_price FROM accommodation_facilities WHERE id = (SELECT accommodation_facility FROM accommodation_units WHERE id = {accommodationUnitId})";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return new AccommodationFacilityInfo
                        {
                            IdNO = Convert.ToInt32(reader["id"]),
                            TaxPrice = Convert.ToDecimal(reader["ttax_price"])
                        };
                    }
                }
            }

            return new AccommodationFacilityInfo(); // Return default values if data is not found
        }

        public class AccommodationFacilityInfo
        {
            public int IdNO { get; set; }
            public decimal TaxPrice { get; set; }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
    }
}
