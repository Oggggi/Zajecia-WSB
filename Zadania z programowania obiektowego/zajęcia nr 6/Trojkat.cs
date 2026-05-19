using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Trojkat
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public Trojkat(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        private double Pole()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        private double Obwod()
        {
            return a + b + c;
        }

        private double ProporcjaPoleDoObwod()
        {
            return Pole() / Obwod();
        }

        public static bool operator >(Trojkat t1, Trojkat t2)
        {
            return t1.ProporcjaPoleDoObwod() > t2.ProporcjaPoleDoObwod();
        }

        public static bool operator <(Trojkat t1, Trojkat t2)
        {
            return t1.ProporcjaPoleDoObwod() < t2.ProporcjaPoleDoObwod();
        }
    }
}
