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
       private DataTable dtProizvodi = new DataTable(); //kreiranje nove tablice za proizvode
        private string xmlFilePath = "Trgovina.xml"; // putanja do XML fajla
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

        }

        private void Pocetna_Load(object sender, EventArgs e)
        {
            comboBoxKategorija.SelectedIndex = 0; // postavljanje početne vrijednosti za combobox

            //postavljanje kolone u DataTable
            dtProizvodi.Columns.Add("ID");
            dtProizvodi.Columns.Add("Naziv");
            dtProizvodi.Columns.Add("Kategorija");
            dtProizvodi.Columns.Add("Cijena");
            dtProizvodi.Columns.Add("Količina");

            
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
