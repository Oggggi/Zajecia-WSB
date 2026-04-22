using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
Rozwiaz problem z metoda Pole() trzema sposobami:
1.Tworzac metode w klasie bazowej i stosujac polimorfizm
2.Stosujac wlasciwosc GetType().Name i rzutowanie
3.Stosujac metode abstrakcyjna w klasie bazowej
*/
namespace polimorfizm
{
    //dla sposobu 1 i 2 klasa może zostać bez zmian, natomiast sposób 3 wymaga klasy abstrakcyjnej
    public abstract class Czworobok
    {
        protected int x;
        protected int y;
        public Czworobok(int bok_a, int bok_b)
        {
            x = bok_a;
            y = bok_b;
        }
        // metoda sposobu 1 z polimorfizmem
        /*public virtual double Pole()
        {
            return 0;
        }*/

        //sposób 3 z metodą abstrakcyjną
        public abstract double Pole();
    }

    public class Kwadrat : Czworobok
    {
        public Kwadrat(int bok_a)
            : base(bok_a, bok_a)
        {
        }

        //do sposobu 1 i 3 trzeba dodać overrida do metody
        public override double Pole()
        {
            return x * y;

        }
    }

    public class Prostokat : Czworobok
    {
        public Prostokat(int bok_a, int bok_b)
            : base(bok_a, bok_b)
        {
        }

        //do sposobu 1 i 3 trzeba dodać overrida do metody
        public override double Pole()
        {
            return x * y;

        }
    }



    class pokazik
    {

        public static void Main()
        {
            Czworobok kw = new Kwadrat(5);
            Czworobok pr = new Prostokat(5, 4);
            //sposób 2 z GetType().Name i rzutowaniem
            /*
            foreach (var figura in tab2)
            {
                if (figura.GetType().Name == "Kwadrat")
                {
                    Kwadrat k = (Kwadrat)figura;
                    Console.WriteLine(k.Pole());
                }
                else if (figura.GetType().Name == "Prostokat")
                {
                    Prostokat p = (Prostokat)figura;
                    Console.WriteLine(p.Pole());
                }
            }
            */
            Czworobok[] tab = { kw, pr };
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i].Pole());
            }
        }
    }
}
