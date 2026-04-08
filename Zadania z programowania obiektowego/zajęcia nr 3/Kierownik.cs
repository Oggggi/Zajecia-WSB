using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Kierownik : Pracownik
    {
        public Kierownik(string nazwisko, string imie, double p_zasadnicza) : base(nazwisko, imie, p_zasadnicza)
        {
        }
        public override double Premia()
        {
            return 0.5 * p_zasadnicza;
        }
    }
}
