using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Plaszczyzna : Prosta
    {
        public double y;
        public Plaszczyzna(double x, double y) : base(x)
        {
            this.y = y;
        }

        public double Odl_zero()
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
}
