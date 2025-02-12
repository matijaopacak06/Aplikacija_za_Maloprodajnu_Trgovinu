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
    public partial class Kasa : Form
    {
       
        

        public Kasa()
        {
            InitializeComponent();
        }

        

        private void btnDodajProizvoda_Click(object sender, EventArgs e)
        {
            //Dobivene  vrijednosti sa forme
            string kategorija = comboBoxKategorija.SelectedItem.ToString(); //Odabrane vrijednosti iz kategorije
            string nazivProizvoda = textBoxNazivProizvoda.Text; //upisivanje  vrijednosti iz naziva proizvoda
            int kolicina = (int)numericUpDownKolicina.Value; // upisivanje kolicine proizvoda

            dataGridView1.Rows.Add(kategorija, nazivProizvoda, kolicina);
        }

        

        private void Pocetna_Load(object sender, EventArgs e)
        {
            comboBoxKategorija.SelectedIndex = 0; // postavljanje početne vrijednosti za combobox

        }
        

        

        
        
    }
}
