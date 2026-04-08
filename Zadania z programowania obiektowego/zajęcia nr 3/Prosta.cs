using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Prosta
    {
        public double x;
        public Prosta(double x)
        {
            this.x = x;
        }

        public double Odl_zero()
        {
            return Math.Abs(x);
        }
    }
}
