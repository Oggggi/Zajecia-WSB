using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Dyrektor : Kierownik
    {
        public Dyrektor(string nazwisko, string imie, double p_zasadnicza) : base(nazwisko, imie, p_zasadnicza)
        {
        }
        public override double Premia()
        {
            return base.Premia() + 2000;
        }
    }
}
