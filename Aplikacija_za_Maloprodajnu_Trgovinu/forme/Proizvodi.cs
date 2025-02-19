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
using System.IO;

namespace Aplikacija_za_Maloprodajnu_Trgovinu.forme
{
    public partial class Proizvodi : Form
    {
        private string xmlFile = "proizvodi.xml";
        public Proizvodi()
        {
            InitializeComponent();
        }

        private void Proizvodi_Load(object sender, EventArgs e)
        {

        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

         

            if (File.Exists(xmlFile))
            {
                XDocument doc = XDocument.Load(xmlFile);
                foreach (XElement element in doc.Descendants("Proizvod"))
                {
                    dataGridView1.Rows.Add(
                        element.Attribute("ID_Proizvod").Value, // Dohvaćamo atribut ID_Proizvod
                        element.Element("Naziv").Value,
                        element.Element("Opis").Value,
                        element.Element("Cijena").Value,
                        element.Element("Kategorija").Value,
                        element.Element("Količina").Value,
                        element.Element("Jedinica_mjere").Value);
                }
            }
            else
            {
                MessageBox.Show("XML datoteka ne postoji!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
