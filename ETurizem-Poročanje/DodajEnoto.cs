using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ETurizem_Poročanje
{
    public partial class DodajEnoto : Form
    {
        eturizemDataSet eturizemDataSet = new eturizemDataSet();
        eturizemDataSetTableAdapters.accommodation_facilitiesTableAdapter afta = new eturizemDataSetTableAdapters.accommodation_facilitiesTableAdapter();
        eturizemDataSetTableAdapters.accommodation_unitsTableAdapter auta = new eturizemDataSetTableAdapters.accommodation_unitsTableAdapter();
        private NastavitveneEnote _nasEnoForm;
        private DataRow clickedRow;

        public DodajEnoto()
        {
            InitializeComponent();
        }

        public DodajEnoto(NastavitveneEnote nasEnoForm, bool editing, DataRow row)
        {
            InitializeComponent();
            _nasEnoForm = nasEnoForm;
            clickedRow = row;
            if (editing)
            {
                this.Text = "Urejanje enote";
                label1.Text = "Urejanje enote: " + clickedRow[1];
                dodajObratButton.Text = "Potrdi";

                comboBoxFacilities.SelectedValue = clickedRow[1].ToString();
                textBox1.Text = clickedRow[2].ToString();
                numericUpDown1.Text = clickedRow[3].ToString();
                textBox2.Text = clickedRow[4].ToString();
            }
        }

        private void DodajEnoto_Load(object sender, EventArgs e)
        {
            afta.Fill(eturizemDataSet.accommodation_facilities);

            comboBoxFacilities.DataSource = eturizemDataSet.accommodation_facilities;
            comboBoxFacilities.DisplayMember = "title";
            comboBoxFacilities.ValueMember = "id";
        }

        private void comboBoxFacilities_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxFacilities.DisplayMember = "title";
        }

        private void dodajObratButton_Click(object sender, EventArgs e)
        {
            if (clickedRow == null)
            {
                if (double.TryParse(textBox2.Text, out double cena) && int.TryParse(comboBoxFacilities.SelectedValue.ToString(), out int obratID))
                {
                    try
                    {
                        auta.Insert(obratID, textBox1.Text, (int)numericUpDown1.Value, cena);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Napaka: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Neveljavna vrednost za številsko polje.");
                }
            }
            else 
            {
                if (double.TryParse(textBox2.Text, out double cena) && int.TryParse(comboBoxFacilities.SelectedValue.ToString(), out int obratID))
                {
                    try
                    {
                        eturizemDataSet.accommodation_facilitiesDataTable dataTable = new eturizemDataSet.accommodation_facilitiesDataTable();
                        afta.Fill(dataTable);
                        clickedRow[1] = obratID;
                        clickedRow[2] = textBox1.Text;
                        clickedRow[3] = numericUpDown1.Text;
                        clickedRow[4] = cena;
                        auta.Update(clickedRow);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Napaka: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Neveljavna vrednost za številsko polje.");
                }
            }
        }

        private void DodajEnoto_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(_nasEnoForm != null)
            {
                _nasEnoForm.ReloadGridView();
            }
        }
    }
}
