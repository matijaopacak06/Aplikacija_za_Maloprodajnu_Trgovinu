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
        }

        private void btnIzdajRacun_Click(object sender, EventArgs e)
        {
            Racun racunForma = new Racun(); // Kreiram formu Racun
            racunForma.Show(); // Prikazujemo formu kao novi  prozor

        }
    }
}
