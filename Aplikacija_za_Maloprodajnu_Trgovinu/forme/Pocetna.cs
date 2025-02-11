using Aplikacija_za_Maloprodajnu_Trgovinu.klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Aplikacija_za_Maloprodajnu_Trgovinu.forme
{
    public partial class Pocetna : Form
    {
       
        private string xmlFilePath = AppDomain.CurrentDomain.BaseDirectory + "\"C:\\\\Users\\\\Učenik\\\\source\\\\repos\\\\Aplikacija_za_Maloprodajnu_Trgovinu\\\\Aplikacija_za_Maloprodajnu_Trgovinu\";"; // putanja do XML fajla

        public Pocetna()
        {
            InitializeComponent();
        }

        private void btnDodajKupca_Click(object sender, EventArgs e)
        {
            Kupci kupciForma = new Kupci(); // Kreiram formu Kupci
            kupciForma.Show(); // Prikazujemo formu kao novi  prozor
        }

        private void btnDodajProizvoda_Click(object sender, EventArgs e)
        {
            //Dobivene  vrijednosti sa forme
            string kategorija = comboBoxKategorija.SelectedItem.ToString(); //Odabrane vrijednosti iz kategorije
            string nazivProizvoda = textBoxNazivProizvoda.Text; //upisivanje  vrijednosti iz naziva proizvoda
            int kolicina = (int)numericUpDownKolicina.Value; // upisivanje kolicine proizvoda

            dataGridView1.Rows.Add(kategorija, nazivProizvoda, kolicina);
        }

        private void btnIzdajRacun_Click(object sender, EventArgs e)
        {
            Racun racunForma = new Racun(); // Kreiram formu Racun
            racunForma.Show(); // Prikazujemo formu kao novi  prozor


            string odabranaKategorija = comboBoxKategorija.SelectedItem.ToString();
            string nazivProizvoda = textBoxNazivProizvoda.Text.Trim();
            int kolicinaKupovina = (int)numericUpDownKolicina.Value;

            if (string.IsNullOrEmpty(nazivProizvoda) || kolicinaKupovina <= 0)
            {
                MessageBox.Show("Molimo unesite naziv proizvoda i količinu veću od 0.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                XDocument xmlDoc = XDocument.Load(xmlFilePath);
                var proizvod = xmlDoc.Descendants("Proizvod")
                                     .FirstOrDefault(p => (string)p.Element("Naziv") == nazivProizvoda &&
                                                          (string)p.Element("Kategorija") == odabranaKategorija);

                if (proizvod != null)
                {
                    int trenutnaKolicina = int.Parse(proizvod.Element("Kolicina").Value);
                    decimal cijena = decimal.Parse(proizvod.Element("Cijena").Value);

                    if (kolicinaKupovina > trenutnaKolicina)
                    {
                        MessageBox.Show("Nema dovoljno proizvoda na stanju.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Oduzimanje kupljene količine
                    proizvod.Element("Kolicina").Value = (trenutnaKolicina - kolicinaKupovina).ToString();
                    xmlDoc.Save(xmlFilePath);

                    // Dodajemo proizvod u listu kupljenih proizvoda
                    List<Tuple<string, int, decimal>> listaProizvoda = new List<Tuple<string, int, decimal>>
            {
                new Tuple<string, int, decimal>(nazivProizvoda, kolicinaKupovina, cijena)
            };

                    
                }
                else
                {
                    MessageBox.Show("Proizvod nije pronađen u odabranoj kategoriji.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri ažuriranju XML fajla: " + ex.Message);
            }
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {
            comboBoxKategorija.SelectedIndex = 0; // postavljanje početne vrijednosti za combobox

            UcitajKategorije();




        }
        private void UcitajKategorije()
        {
            try
            {
                XDocument xmlDoc = XDocument.Load(xmlFilePath); // ucitava dokumente iz xml fajla
                var kategorije = xmlDoc.Descendants("Proizvod") // pronalazi sve proizvode
                                       .Select(p => (string)p.Element("Kategorija")) // uzima vrijednost iz kategorije
                                       .Distinct() // svaka kategorija bude u listi
                                       .ToList(); // onda pretvara rezultat u listu

                comboBoxKategorija.Items.AddRange(kategorije.ToArray()); // dodaje sve kategorije u combobox
                comboBoxKategorija.SelectedIndex = 0; // Postavi prvu kategoriju
            }
            catch (Exception ex)
            {
               
            }
        

    }

        private void btnIzbriši_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // provjeravamo ako je neki red označen 
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index); //uklanjamo red koji smo označili
            }
            else
            {
                MessageBox.Show("Molimo vas da odaberete proizvod koji želite izbrisati." , "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); // dajemo upozorenje u novom prozorčiću
            }
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) //provjeravamo dali je neki red odabran/označen
            {
                int index = dataGridView1.SelectedRows[0].Index; // uzimamo indekse od reda kojeg smo odabrali/označili
               
                //ažuriranje podataka u tablici
                dataGridView1.Rows[index].Cells[0].Value = comboBoxKategorija.Text;
                dataGridView1.Rows[index].Cells[0].Value = textBoxNazivProizvoda.Text;
                dataGridView1.Rows[index].Cells[0].Value = numericUpDownKolicina.Value;

            }
            else
            {
                MessageBox.Show("Molimo vas da odaberete proizvod koji želite urediti." , "Upozorenje", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); //dajemo upozorenje u novom prozorčiću
            }
        }
    }
}
