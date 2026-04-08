using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Prostokat : Figura
    {
        public double bok1;
        public double bok2;

        public Prostokat(double bok1, double bok2, string kolor, bool wypelnienie) : base(kolor, wypelnienie)
        {
            this.bok1 = bok1;
            this.bok2 = bok2;
        }

        public Prostokat(double bok, string kolor, bool wypelnienie) : base(kolor, wypelnienie)
        {
            this.bok1 = bok;
            this.bok2 = bok;
        }

        public string ObliczPole()
        {
            double pole = bok1 * bok2;
            return $"Pole: {pole}";
        }

        public override string ToString()
        {
            return $"{GetType().Name} - Bok 1: {bok1}, Bok 2: {bok2}, Pole: {ObliczPole()}";
        }
    }
}
