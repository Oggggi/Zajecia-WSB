using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Pracownik : Osoba
    {
        private string wydzial;

        public Pracownik(string imie, string nazwisko, string wydzial) : base(imie, nazwisko)
        { 
            this.wydzial = wydzial;
        }

        public string Wydzial
        {
            get { return wydzial; }
            set { wydzial = value; }
        }
    }
}
