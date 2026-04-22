using System;
using System.Collections.Generic;
using System.Text;
/* Utwórz dwa interfejsy oraz klasę pochodną, a
następnie stwórz obiekt i przetestuj program*/
namespace ConsoleApp4
{
    interface ICzlowiek1
    {
        void Idz(int x);
        void Biegnij(int x);
        void Biegnij();
    }
    interface ICzlowiek2
    {
        void Przyspiesz();
        void Zwolnij();
    }
    class Czlowiek : ICzlowiek1, ICzlowiek2
    {
        private double predkosc = 0;
        private bool czyBiegnie = false;

        public void Idz(int x)
        {
            predkosc = Math.Max(0, x);
            czyBiegnie = false;
            Console.WriteLine($"Idzie z prędkością {predkosc} km/h");
        }

        public void Biegnij(int x)
        {
            predkosc = Math.Max(0, x);
            czyBiegnie = true;
            Console.WriteLine($"Biegnie z prędkością {predkosc} km/h");
        }

        public void Biegnij()
        {
            if (predkosc == 0)
            {
                predkosc++;
            }
            predkosc *= 2;
            czyBiegnie = true;
            Console.WriteLine($"Biegnie z prędkością {predkosc} km/h");
        }

        public void Przyspiesz()
        {
            if (czyBiegnie == true)
            {
                predkosc += 2;
                Console.WriteLine($"Przyspieszył do {predkosc}");

            }
            else
            {
                predkosc += 1;
                Console.WriteLine($"Przyspieszył do {predkosc}");
            }
        }

        public void Zwolnij()
        {
            predkosc /= 2;
            if (predkosc < 1)
            {
                czyBiegnie= false;
                Console.WriteLine("Spaceruje lub stoi");
                predkosc = 0;
            }
            else
            {
                Console.WriteLine($"Zwolnił do {predkosc}");
            }
        }
    }
}
