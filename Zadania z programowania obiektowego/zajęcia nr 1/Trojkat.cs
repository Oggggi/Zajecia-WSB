using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_Punkt
{
    class Trojkat
    {
        private double bok;
        public double Bok
        {
            get { return bok; }
            set
            {
                bok = value;
                Wysokosc = (bok * Math.Sqrt(3)) / 2;
            }
        }

        public double Wysokosc { get; private set; }

        public double ObliczPole()
        {
            return (Bok * Wysokosc) / 2;
        }
    }
}
