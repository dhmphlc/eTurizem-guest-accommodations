using ETurizem_Poročanje.eturizemDataSetTableAdapters;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ETurizem_Poročanje.DodajGosta;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ETurizem_Poročanje
{
    public partial class DodajGosta : Form
    {
        private DataRow clickedRow;
        eturizemDataSet eturizemDataSet = new eturizemDataSet();
        eturizemDataSetTableAdapters.guest_bookTableAdapter guat = new eturizemDataSetTableAdapters.guest_bookTableAdapter();
        eturizemDataSetTableAdapters.accommodation_unitsTableAdapter auta = new eturizemDataSetTableAdapters.accommodation_unitsTableAdapter();
        private KnjigaGostov _knjigaGostovForm;
        private List<Taksa> takse;
        private List<Dokument> dokumentList;

        public class Dokument
        {
            public string Name { get; set; }
            public char Value { get; set; }

            public char ReturnValue() {
                return Value;
            }
        }
        public class Država
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }
        public class Taksa
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Discount { get; set; }
        }
        public class Enota
        {
            public string Title { get; set; }
            public int ID { get; set; }
        }
        public DodajGosta()
        {
            InitializeComponent();
            InitializeOtherCompontents();
        }

        public void InitializeOtherCompontents()
        {
            DodajVseDrzave();
            DodajVseDokuemnte();
            DodajVseTakse();
            DodajVseEnote();
            datumPrihodaDP.Value = DateTime.Now;
            uraPrihodaDP.Value = DateTime.Now;
            datumOdhodaDP.Value = DateTime.Today.AddDays(1);
            uraOdhodaDP.Value = DateTime.Now;
        }

        private void DodajVseDrzave()
        {
            var countries = new ArrayList();
            foreach (CultureInfo culture in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                var region = new RegionInfo(culture.LCID);
                if (!countries.Contains(region.EnglishName))
                {
                    countries.Add(region.EnglishName);
                    državaBox.Items.Add(new Država { Name = region.EnglishName, Value = region.TwoLetterISORegionName });
                }
            }

            državaBox.DisplayMember = "Name";
            državaBox.ValueMember = "Value";
            državaBox.Sorted = true;
        }

        private void DodajVseDokuemnte()
        {
            dokumentList = new List<Dokument>
            {
                new Dokument { Name = "Osebna iskaznica", Value = 'I' },
                new Dokument { Name = "Obmejna prepustnica", Value = 'F' },
                new Dokument { Name = "Potne listine po mednarodni pogodbi", Value = 'H' },
                new Dokument { Name = "Otroci, državljani RS, brez dokumenta", Value = 'L' },
                new Dokument { Name = "Orožni list", Value = 'O' },
                new Dokument { Name = "Potni list", Value = 'P' },
                new Dokument { Name = "Upravne listine", Value = 'U' },
                new Dokument { Name = "Vozniško dovoljenje", Value = 'V' },
            };

            vrstaDokBox.DataSource = dokumentList;
            vrstaDokBox.DisplayMember = "Name";
            vrstaDokBox.ValueMember = "Value";
        }

        private void DodajVseTakse()
        {
            takse = new List<Taksa>
            {
                new Taksa { Id = 0, Name = "0 - Polna turistična taksa (ni oprostitve)", Discount = 0},
                new Taksa { Id = 1, Name = "1 - Oprostitev - otrok do 7. leta starosti", Discount = 100 },
                new Taksa { Id = 2, Name = "2 - Oprostitev - zdravniška napotnica", Discount = 100 },
                new Taksa { Id = 3, Name = "3 - Oprostitev - invalidnost, telesna okvara", Discount = 100 },
                new Taksa { Id = 4, Name = "4 - Oprostitev - otrok s posebnimi potrebami", Discount = 100 },
                new Taksa { Id = 5, Name = "5 - Oprostitev - vzgojno-izobraževalni program", Discount = 100 },
                new Taksa { Id = 6, Name = "6 - Oprostitev - dijaki, študenti v domovih", Discount = 100 },
                new Taksa { Id = 7, Name = "7 - Delno plačilo – osebe na začasnem delu (polna taksa do 30 dni, oprostitev nad 30 dni)." , Discount = 50},
                new Taksa { Id = 8, Name = "8 - Oprostitev - mednarodna pogodba", Discount = 100 },
                new Taksa { Id = 9, Name = "9 - Oprostitev - planinski dom (člani PZS)", Discount = 100 },
                new Taksa { Id = 10, Name = "10 - Oprostitev - predpis občine", Discount = 100 },
                new Taksa { Id = 11, Name = "11 - Polovično plačilo (50%) - oseba od 7. do 18. leta starosti", Discount = 50},
                new Taksa { Id = 12, Name = "12 - Polovično plačilo (50%) - mladinska prenočišča IYHF (osebe od 18. do 30. leta)", Discount = 50 },
                new Taksa { Id = 13, Name = "13 - Polovično plačilo (50%) - turisti v kampih", Discount = 50 },
                new Taksa { Id = 14, Name = "14 - Polovično plačilo (50%) - predpis občine", Discount = 50 },
                new Taksa { Id = 15, Name = "15 - Delno plačilo - predpis občine", Discount = 50 },
                new Taksa { Id = 16, Name = "16 - Ni plačila - ni storitve prenočevanja (dnevni počitek, ipd.)", Discount = 100 },
                new Taksa { Id = 17, Name = "17 - Oprostitev - udeleženci letovanj prek društev v javnem interesu", Discount = 100 },
                new Taksa { Id = 18, Name = "18 - Oprostitev - prostovoljci za odpravo elementarnih nesreč", Discount = 100 },
                new Taksa { Id = 19, Name = "19 - Oprostitev - policisti v obdobju opravljanja nalog", Discount = 100 },
            };
            ttBox.DataSource = takse;
            ttBox.DisplayMember = "Name";
            ttBox.ValueMember = "Id";
        }

        public string GetTaksaImeByID(int idTakse)
        {
            Taksa taksa = takse.FirstOrDefault(t => t.Id == idTakse);
            return taksa?.Name; // return taksa.Name if taksa.Name is not null, otherwise return null
        }

        public string GetDokumentImeByChar(char docChar)
        {
            Dokument dokument = dokumentList.FirstOrDefault(t => t.Value == docChar);
            return dokument?.Name;
        }

        public string GetCountryNameByID(string idCountry)
        {
            Država selectedCountry = državaBox.Items.OfType<Država>().FirstOrDefault(country => country.Value == idCountry);
            if (selectedCountry != null)
            {
                return selectedCountry.Name;
            }
            return "-";
        }

        public void LoadGuest(KnjigaGostov knjGostForm, bool editing, DataRow row)
        {
            _knjigaGostovForm = knjGostForm;
            clickedRow = row;
            if (editing)
            {
                this.Text = "Urejanje gosta";
                label14.Text = "Urejanje gosta: "+ clickedRow[0]+ " " + clickedRow[1] + " " + clickedRow[2];
                addGuestBtn.Text = "Potrdi";

                imeBox.Text = clickedRow[1].ToString();
                priimekBox.Text = clickedRow[2].ToString();

                object valueFromRow = clickedRow[3];
                foreach (Država drzava in državaBox.Items)
                {
                    if (drzava.Value == valueFromRow.ToString())
                    {
                        državaBox.SelectedItem = drzava;
                        break;
                    }
                }

                string dateString = clickedRow[4].ToString();
                DateTime datumRojstva;
                if (DateTime.TryParseExact(dateString, "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out datumRojstva))
                {
                    datumRojstvaDP.Value = datumRojstva;
                }
                spolRadBtn1.Checked = (clickedRow[5].ToString() == "M");
                spolRadBtn2.Checked = (clickedRow[5].ToString() == "F");

                char vrstaDokumenta = char.Parse(clickedRow[6].ToString());
                foreach (Dokument dokument in vrstaDokBox.Items)
                {
                    if(dokument.Value == vrstaDokumenta)
                    {
                        vrstaDokBox.SelectedItem = dokument;
                    }
                }

                stDokBox.Text = clickedRow[7].ToString();
                datumPrihodaDP.Text = clickedRow[8].ToString();
                uraPrihodaDP.Text = clickedRow[9].ToString();
                datumOdhodaDP.Text = clickedRow[10].ToString();
                uraOdhodaDP.Text = clickedRow[11].ToString();

                object tTaksa = clickedRow[12];
                foreach (Taksa taksa in ttBox.Items)
                {
                    if(taksa.Id == int.Parse(tTaksa.ToString())){
                        ttBox.SelectedItem = taksa;
                        break;
                    }
                }

                object enotaId = clickedRow[13];
                DataRowView selectedRowView = (DataRowView)enotaBox.Items
                                            .Cast<DataRowView>()
                                            .FirstOrDefault(rowView => (int)rowView.Row["ID"] == int.Parse(enotaId.ToString()));
                if (selectedRowView != null)
                {
                    enotaBox.SelectedItem = selectedRowView;
                }
            }
        }

        private void DodajVseEnote()
        {
            auta.Fill(eturizemDataSet.accommodation_units);

            enotaBox.DataSource = eturizemDataSet.accommodation_units;
            enotaBox.DisplayMember = "title";
            enotaBox.ValueMember = "ID";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addGuestBtn_Click(object sender, EventArgs e)
        {
            String spol = "";
            if (clickedRow == null)
            {
                if (imeBox.Text == "" || priimekBox.Text == "" || državaBox.SelectedItem == null || vrstaDokBox.SelectedValue == null || stDokBox.Text == "" || ttBox.SelectedItem == null || enotaBox.SelectedValue == null || datumPrihodaDP.Value == null || datumOdhodaDP.Value == null || uraPrihodaDP.Value == null || uraOdhodaDP.Value == null || datumRojstvaDP.Value == null)
                {
                    MessageBox.Show("Manjka vnos", "Opozorilo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string selectedDržava = ((Država)državaBox.SelectedItem).Value; // država
                    char selectedDokument = Convert.ToChar(vrstaDokBox.SelectedValue); // tip dokumenta
                    int selectedTaksa = ((Taksa)ttBox.SelectedItem).Id; // tip takse
                    int selectedEnota = Convert.ToInt32(enotaBox.SelectedValue); // enota
                    spol = spolRadBtn1.Checked ? "M" : spolRadBtn2.Checked ? "F" : null; // spol
                    string formattedDateArrivalString = datumPrihodaDP.Value.ToString("dd/MM/yyyy"); // datum prihoda
                    string formattedDateDepatrueString = datumOdhodaDP.Value.ToString("dd/MM/yyyy"); // datum odhoda
                    string formattedTimeArrivalString = uraPrihodaDP.Value.ToString("hh:mm"); // ura prihoda
                    string formattedTimeDepatueString = uraOdhodaDP.Value.ToString("hh:mm"); // ura odhoda
                    string formattedDatumRojstva = datumRojstvaDP.Value.ToString("dd/MM/yyyy"); // datum rojstva

                    //insert into guest book table adapter
                    guat.Insert(imeBox.Text, priimekBox.Text, selectedDržava, formattedDatumRojstva, spol, selectedDokument.ToString(), stDokBox.Text, formattedDateArrivalString, formattedTimeArrivalString, formattedDateDepatrueString, formattedTimeDepatueString, selectedTaksa, selectedEnota, 0, 0);
                    this.Close(); // zapri dialog 
                }
            }
            else
            {
                if (imeBox.Text == "" || priimekBox.Text == "" || državaBox.SelectedItem == null || vrstaDokBox.SelectedValue == null || stDokBox.Text == "" || ttBox.SelectedItem == null || enotaBox.SelectedValue == null || datumPrihodaDP.Value == null || datumOdhodaDP.Value == null || uraPrihodaDP.Value == null || uraOdhodaDP.Value == null || datumRojstvaDP.Value == null)
                {
                    MessageBox.Show("Manjka vnos", "Opozorilo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string selectedDržava = ((Država)državaBox.SelectedItem).Value; // država
                    char selectedDokument = Convert.ToChar(vrstaDokBox.SelectedValue); // tip dokumenta
                    int selectedTaksa = ((Taksa)ttBox.SelectedItem).Id; // tip takse
                    int selectedEnota = Convert.ToInt32(enotaBox.SelectedValue); // enota
                    spol = spolRadBtn1.Checked ? "M" : spolRadBtn2.Checked ? "F" : ""; // spol
                    string formattedDateArrivalString = datumPrihodaDP.Value.ToString("dd/MM/yyyy");
                    string formattedDateDepatrueString = datumOdhodaDP.Value.ToString("dd/MM/yyyy");
                    string formattedTimeArrivalString = uraPrihodaDP.Value.ToString("hh:mm");
                    string formattedTimeDepatueString = uraOdhodaDP.Value.ToString("hh:mm");
                    string formattedDatumRojstva = datumRojstvaDP.Value.ToString("dd/MM/yyyy");

                    clickedRow[1] = imeBox.Text;
                    clickedRow[2] = priimekBox.Text;
                    clickedRow[3] = selectedDržava;
                    clickedRow[4] = formattedDatumRojstva;
                    clickedRow[5] = spol;
                    clickedRow[6] = selectedDokument;
                    clickedRow[7] = stDokBox.Text;
                    clickedRow[8] = formattedDateArrivalString;
                    clickedRow[9] = formattedTimeArrivalString;
                    clickedRow[10] = formattedDateDepatrueString;
                    clickedRow[11] = formattedTimeDepatueString;
                    clickedRow[12] = selectedTaksa;
                    clickedRow[13] = selectedEnota;
                    clickedRow[14] = 0;

                    guat.Update(clickedRow);
                    this.Close();
                }
                
            }
        }

        private void DodajGosta_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(_knjigaGostovForm != null)
            {
                _knjigaGostovForm.RefreshDataGridView();
            }
        }

        private void ttBox_DropDown(object sender, EventArgs e)
        {
            Graphics g = ttBox.CreateGraphics();
            float maxWidth = 0f;
            foreach (object o in ttBox.Items)
            {
                float w = g.MeasureString(o.ToString(), ttBox.Font).Width;
                if (w > maxWidth)
                {
                    maxWidth = w;
                }
            }
            g.Dispose();
            ttBox.Width = (int)maxWidth + 20; // 20 is to take care of button width
        }

        private void ttBox_DropDownClosed(object sender, EventArgs e)
        {
            ttBox.Width = 148;
        }
    }
}
