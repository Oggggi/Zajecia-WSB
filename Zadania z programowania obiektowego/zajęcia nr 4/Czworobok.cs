using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    abstract class Czworobok
    {
        protected double x;
        protected double y;

        public Czworobok(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract double Pole();
    }
    class Kwadrat : Czworobok
    {
        public Kwadrat(double x) : base(x, x)
        {
        }

        public override double Pole()
        {
            return x * x;
        }
    }
    class Prostokat : Czworobok
    {
        public Prostokat(double x, double y) : base(x, y)
        {
        }

        public override double Pole()
        {
            return x * y;
        }
    }
    class Trapez : Czworobok
    {
        private double wysokosc;

        public Trapez(double x, double y, double wysokosc) : base(x, y)
        {
            this.wysokosc = wysokosc;
        }

        public override double Pole()
        {
            return ((x + y) / 2) * wysokosc;
        }
    }

}
