using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Osoba
    {
        private string nazwisko;
        private string imie;

        public Osoba(string imie, string nazwisko)
        {
            this.nazwisko = nazwisko;
            this.imie = imie;
        }

        public string Nazwisko
        {
            get { return nazwisko; }
        }

        public string Imie
        {
            get { return imie; }
        }
    }
}
