using System;
using System.Collections.Generic;
using System.Text;
/*Utwórz klasę Kwadrat implementującą właściwość obwód jako obwód
kwadratu (akcesor get) oraz metodę Pole() jako pole kwadratu. W klasie ma
być utworzonykonstruktor parametryczny inicjujący pole bok_a
Utwórz klasę Trojkat implementującą właściwość obwód jako obwód trójkąta
(akcesor get) oraz metodę Pole() jako pole trójkąta (wzór Herona). W klasie
ma być utworzony konstruktor parametryczny inicjujący pola bok_a, bok_b,
bok_c*/
namespace ConsoleApp4
{
    interface IFigury
    {
        double Obwod { get; }
        double Pole();
    }
    class KwadratI : IFigury
    {
        private double bok_a;

        public KwadratI(double bok_a)
        {
            this.bok_a = bok_a;
        }

        public double Obwod => 4 * bok_a;

        public double Pole()
        {
            return bok_a * bok_a;
        }
    }
    class Trojkat : IFigury
    {
        private double bok_a;
        private double bok_b;
        private double bok_c;

        public Trojkat(double bok_a, double bok_b, double bok_c)
        {
            if (bok_a + bok_b <= bok_c || bok_a + bok_c <= bok_b || bok_b + bok_c <= bok_a){
                throw new ArgumentException("Niepoprawne boki trójkąta");
            }

            this.bok_a = bok_a;
            this.bok_b = bok_b;
            this.bok_c = bok_c;
        }

        public double Obwod => bok_a + bok_b + bok_c;

        public double Pole()
        {
            double p = Obwod / 2;
            return Math.Sqrt(p * (p - bok_a) * (p - bok_b) * (p - bok_c));
        }
    }
}
