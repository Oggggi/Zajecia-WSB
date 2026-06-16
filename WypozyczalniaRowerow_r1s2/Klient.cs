using System;
using System.Collections.Generic;
using System.Text;

namespace WypozyczalniaRowerow
{
    public class Klient
    {
        public string Imie { get; set; }

        public string Nazwisko { get; set; }

        public string Telefon { get; set; }

        public Klient(string imie, string nazwisko, string telefon)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Telefon = telefon;
        }

        public override string ToString()
        {
            return $"{Imie} {Nazwisko} | Tel.: {Telefon}";
        }
    }
}
