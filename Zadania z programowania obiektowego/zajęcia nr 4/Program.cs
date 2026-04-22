using ConsoleApp4;
using System;
using System.Text;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //zadanie 1 (Czworobok)
            Czworobok[] czworoboki = new Czworobok[3];
            czworoboki[0] = new Kwadrat(5);
            czworoboki[1] = new Prostokat(5, 4);
            czworoboki[2] = new Trapez(7, 8, 6);

            foreach (Czworobok c in czworoboki)
            {
                Console.WriteLine($"Pole: {c.Pole()}");
            }

            //zadanie 2 (Figury2)
            KwadratI kwadrat = new KwadratI(15);
            Trojkat trojkat = new Trojkat(4, 5, 6);
            Console.WriteLine($"Pole kwadratu: {kwadrat.Pole()}");
            Console.WriteLine($"Pole trójkąta: {trojkat.Pole()}");
            Console.WriteLine($"Obwód kwadratu: {kwadrat.Obwod}");
            Console.WriteLine($"Obwód trójkąta: {trojkat.Obwod}");

            //zadanie 3 (Czlowiek3)
            Czlowiek czlowiek = new Czlowiek();
            czlowiek.Idz(5);
            czlowiek.Przyspiesz();
            czlowiek.Biegnij();
            czlowiek.Przyspiesz();
            czlowiek.Zwolnij();

            Czlowiek czlowiek2 = new Czlowiek();
            czlowiek2.Idz(3);
            czlowiek2.Zwolnij();
            czlowiek2.Zwolnij();
            czlowiek2.Biegnij();
        }
    }
}
