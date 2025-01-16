using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija_za_Maloprodajnu_Trgovinu.klase
{
    internal class Kupac
    {
        int ID_Kupac;
        string Ime;
        string Prezime;
        string Adresa;
        int Telefon;
        string Email;
        int Popust;

        public Kupac(int iD_Kupac, string ime, string prezime, string adresa, int telefon, string email, int popust)
        {
            ID_Kupac = iD_Kupac;
            Ime = ime;
            Prezime = prezime;
            Adresa = adresa;
            Telefon = telefon;
            Email = email;
            Popust = popust;
        }

        public int ID_Kupac1 { get => ID_Kupac; set => ID_Kupac = value; }
        public string Ime1 { get => Ime; set => Ime = value; }
        public string Prezime1 { get => Prezime; set => Prezime = value; }
        public string Adresa1 { get => Adresa; set => Adresa = value; }
        public int Telefon1 { get => Telefon; set => Telefon = value; }
        public string Email1 { get => Email; set => Email = value; }
        public int Popust1 { get => Popust; set => Popust = value; }
    }
}
