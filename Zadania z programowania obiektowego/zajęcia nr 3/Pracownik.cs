using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Pracownik
    {
        protected string nazwisko, imie;
        protected double p_zasadnicza;
        public Pracownik(string nazwisko, string imie, double p_zasadnicza)
        {
            this.nazwisko = nazwisko;
            this.imie = imie;
            this.p_zasadnicza = p_zasadnicza;
        }
        public virtual double Premia()
        {
            return 0.2 * p_zasadnicza;
        }
        
    }
}
