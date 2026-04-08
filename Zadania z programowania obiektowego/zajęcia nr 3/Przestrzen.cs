using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Przestrzen : Plaszczyzna
    {
        public double z;
        public Przestrzen(double x, double y, double z) : base(x, y)
        {
            this.z = z;
        }

        public double Odl_zero()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        public static double Odl_punktow(Przestrzen p1, Przestrzen p2)
        {
            double dx = p1.x - p2.x;
            double dy = p1.y - p2.y;
            double dz = p1.z - p2.z;
            return Math.Sqrt(dx * dx + dy * dy + dz * dz);
        }
    }
}
