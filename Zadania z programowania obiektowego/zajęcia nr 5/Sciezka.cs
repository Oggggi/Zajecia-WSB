using System;
using System.Collections.Generic;
using System.Text;
/*Utwórz strukturę Punkt do reprezentacji
punktów na płaszczyźnie, z dwoma polami x,
y reprezentującymi współrzędne, z
konstruktorem inicjalizującym pola oraz z
jedną metodą Odleglosc obliczającą
odległość dwóch punktów*/
namespace ConsoleApp5
{
    class Sciezka
    {
        public struct Punkt
        {
            public double x;
            public double y;

            public Punkt(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            public double Odleglosc(Punkt innyPunkt)
            {
                return Math.Sqrt(Math.Pow(this.x - innyPunkt.x, 2) + Math.Pow(this.y - innyPunkt.y, 2));
            }
        }
    }
}
