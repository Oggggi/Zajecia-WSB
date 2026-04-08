using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Kolo : Figura
    {
        private double promien;

        public Kolo(double promien, string kolor, bool wypelnienie) : base(kolor, wypelnienie)
        {
            this.promien = promien;
        }

        public Kolo() : base("Brak koloru", false)
        {
            this.promien = 0;
        }

        public void UstawPromien(double promien)
        {
            this.promien = promien;
        }

        public double PobierzPromien()
        {
            return promien;
        }

        public string ObliczPole()
        {
            double pole = Math.PI * promien * promien;
            return $"Promień: {promien}, Pole: {pole}";
        }
    }
}
