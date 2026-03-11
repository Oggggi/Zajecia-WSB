using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_Punkt
{
    class Prostokat
    {
        private double dlugosc;
        private double szerokosc;

        public Prostokat(double dlugosc, double szerokosc)
        {
            this.dlugosc = dlugosc;
            this.szerokosc = szerokosc;
        }

        private double Powierzchnia()
        {
            return dlugosc * szerokosc;
        }

        private double Obwod()
        {
            return 2 * (dlugosc + szerokosc);
        }

        public void Prezentuj()
        {
            Console.WriteLine($"Obwód = {Obwod()}  Powierzchnia = {Powierzchnia()}");
        }

        public static double NajwiekszaPowierzchnia(Prostokat[] prostokaty)
        {
            double maxPowierzchnia = 0;
            foreach (var prostokat in prostokaty)
            {
                double powierzchnia = prostokat.Powierzchnia();
                if (powierzchnia > maxPowierzchnia)
                {
                    maxPowierzchnia = powierzchnia;
                }
            }
            return maxPowierzchnia;
        }
    }
}
