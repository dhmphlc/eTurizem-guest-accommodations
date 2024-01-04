using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ETurizem_Poročanje
{
    public partial class DodajObrat : Form
    {
        private DataRow clickedRow;
        eturizemDataSetTableAdapters.accommodation_facilitiesTableAdapter afta = new eturizemDataSetTableAdapters.accommodation_facilitiesTableAdapter();
        private NastavitveniObrati _nasObrForm;
        public DodajObrat()
        {
            InitializeComponent();
        }
        public DodajObrat(NastavitveniObrati nasObrForm, bool editing, DataRow row)
        {
            InitializeComponent();
            _nasObrForm = nasObrForm;
            clickedRow = row;
            if (editing) {
                this.Text = "Urejanje obrata";
                label1.Text = "Urejanje obrata: " + clickedRow[1];
                dodajObratButton.Text = "Potrdi";

                textBox1.Text = clickedRow[1].ToString();
                textBox2.Text = clickedRow[2].ToString();
                textBox3.Text = clickedRow[3].ToString();
                textBox4.Text = clickedRow[4].ToString();
            }
        }

        private void DodajObrat_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void dodajObratButton_Click(object sender, EventArgs e)
        {
            if (clickedRow == null)
            {
                if (double.TryParse(textBox4.Text, out double result))
                {
                    try
                    {
                        afta.Insert(textBox1.Text, textBox2.Text, double.Parse(textBox3.Text), textBox4.Text);
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
                if (double.TryParse(textBox4.Text, out double result))
                {
                    try
                    {
                        eturizemDataSet.accommodation_facilitiesDataTable dataTable = new eturizemDataSet.accommodation_facilitiesDataTable();
                        afta.Fill(dataTable);
                        clickedRow[1] = textBox1.Text;
                        clickedRow[2] = textBox2.Text;
                        clickedRow[3] = textBox3.Text;
                        clickedRow[4] = textBox4.Text;
                        afta.Update(clickedRow);
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

        private void DodajObrat_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(_nasObrForm != null)
            {
                _nasObrForm.RefreshDataGridView();
            }
        }
    }
}
