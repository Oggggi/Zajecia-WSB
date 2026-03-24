using ConsoleApp2;
using System;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //zadanie 1 "Math2"
            Console.WriteLine("najwiekszy wspolny dzielnik " + Math2.NWD(24, 16));
            Console.WriteLine("najmniejsza wspolna wielokrotnosc " + Math2.NWW(24, 32));

            //zadanie 2 "Figura"
            Figura p1 = new Figura(1);
            Figura p2 = new Figura(4, 5);
            Figura p3 = new Figura(3, 4, 5);
            Figura p4 = new Figura(p3);
            Figura p5 = p3;
            p3.parametr1 = 1;

            Console.WriteLine(p1.ObliczObwod());
            Console.WriteLine(p2.ObliczObwod());
            Console.WriteLine(p3.ObliczObwod());
            Console.WriteLine(p4.ObliczObwod());
            Console.WriteLine(p5.ObliczObwod());

            //zadanie 3 "Samochod"
            Samochod samochod = new Samochod("Toyota", 90, 40);
            samochod.Jedz(450);
            samochod.Tankuj(25);
            samochod.Jedz(300);
            samochod.Jedz(250);

            //zadanie 4 "Osoba"
            Pracownik pracownik = new Pracownik("Jan", "Kowalski", "IT");
            pracownik.Wydzial = "HR";
            Console.WriteLine($"Imię: {pracownik.Imie}, Nazwisko: {pracownik.Nazwisko}, Wydział: {pracownik.Wydzial}");
        }
    }
}
