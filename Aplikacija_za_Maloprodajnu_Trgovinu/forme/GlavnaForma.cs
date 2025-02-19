using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacija_za_Maloprodajnu_Trgovinu.forme
{
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
                                       
            Kasa proizvodiForm = new Kasa(); //kreiram novi objekt forme
            proizvodiForm.Show(); //otvaramo  prozor
        }

        private void btnKupac_Click(object sender, EventArgs e)
        {
            Kupci kupciForm = new Kupci();
            kupciForm.Show();
        }

        private void btnRačun_Click(object sender, EventArgs e)
        {
            Racun racunForm = new Racun();
            racunForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proizvodi proizvodiForm = new Proizvodi();
            proizvodiForm.Show();
        }
    }
}
