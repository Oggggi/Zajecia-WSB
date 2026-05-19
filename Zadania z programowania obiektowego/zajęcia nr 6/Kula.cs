using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Kula
    {
        public double promien { get; set; }

        public Kula(double promien)
        {
            this.promien = promien;
        }

        public double PromienKuli
        {
            get { return promien; }
            set { promien = value; }
        }

        public double Objetosc()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(promien, 3);
        }

        public static Kula operator +(Kula a, Kula b)
        {
            double objetoscSuma = a.Objetosc() + b.Objetosc();
            double nowyPromien = Math.Pow((3 * objetoscSuma) / (4 * Math.PI), 1.0 / 3.0);
            return new Kula(nowyPromien);
        }

        public static Kula operator -(Kula a, Kula b)
        {
            if (a.Objetosc() > b.Objetosc())
            {
                double objetoscRoznica = a.Objetosc() - b.Objetosc();
                double nowyPromien = Math.Pow((3 * objetoscRoznica) / (4 * Math.PI), 1.0 / 3.0);
                return new Kula(nowyPromien);
            }
            else
            {
                return new Kula(0);
            }
        }
    }
}
