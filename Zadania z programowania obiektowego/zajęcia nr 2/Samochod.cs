using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Samochod
    {
        private string model;
        private double pojemnosc;
        private double ilosc_benzyny;

        public Samochod(string model, double pojemnosc, double ilosc_benzyny)
        {
            this.model = model;
            this.pojemnosc = pojemnosc;
            this.ilosc_benzyny = ilosc_benzyny;
        }

        public void Jedz(double km)
        {
            double spalanie = 0.06 * km;
            if (spalanie > ilosc_benzyny)
            {
                Console.WriteLine("Nie masz wystarczającej ilości benzyny, aby przejechać " + km + " km.");
                return;
            }
            ilosc_benzyny -= spalanie;
            Console.WriteLine("Przejechano " + km + " km. " + "Spalono: " + spalanie + " litrów. Pozostało: " + ilosc_benzyny + " litrów benzyny.");
        }

        public void Tankuj(double litry)
        {
            if (ilosc_benzyny + litry > pojemnosc)
            {
                Console.WriteLine("Nie możesz zatankować więcej niż pojemność baku (" + pojemnosc + " litrów).");
                return;
            }
            ilosc_benzyny += litry;
            Console.WriteLine("Po zatankowaniu " + litry + " litrów, masz teraz " + ilosc_benzyny + " litrów benzyny.");
        }
    }
}
