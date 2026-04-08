using ConsoleApp3;
using System;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
         //zadanie 1 (Pracownik)
            List<Pracownik> zaloga = new List<Pracownik>();
            zaloga.Add(new Pracownik("Kowalski", "Jan", 5000));
            zaloga.Add(new Pracownik("Nowak", "Adam", 4500));
            zaloga.Add(new Pracownik("Wiśniewska", "Kasia", 4000));
            zaloga.Add(new Kierownik("Dover", "Ben", 8000));
            zaloga.Add(new Dyrektor("Doe", "John", 10000));
            double sumaPremiiPracownicy = 0;
            double sumaPremiiSzefostwo = 0;
            int liczbaPracownicy = 0;
            int liczbaSzefostwo = 0;
            foreach (var pracownik in zaloga)
            {
                if (pracownik.GetType() == typeof(Pracownik))
                {
                    sumaPremiiPracownicy += pracownik.Premia();
                    liczbaPracownicy++;
                }
                else
                {
                    sumaPremiiSzefostwo += pracownik.Premia();
                    liczbaSzefostwo++;
                }
            }
            double średniaPremiaPracownicy = sumaPremiiPracownicy / liczbaPracownicy;
            double średniaPremiaSzefostwo = sumaPremiiSzefostwo / liczbaSzefostwo;
            Console.WriteLine($"Średnia premia pracowników: {średniaPremiaPracownicy}");
            Console.WriteLine($"Średnia premia szefostwa: {średniaPremiaSzefostwo}");

         //zadanie 2 (Przestrzeń)
            Prosta prosta1 = new Prosta(3);
            Prosta prosta2 = new Prosta(-4);
            Plaszczyzna plaszczyzna1 = new Plaszczyzna(3, 4);
            Plaszczyzna plaszczyzna2 = new Plaszczyzna(-5, 12);
            Przestrzen przestrzen1 = new Przestrzen(1, 2, 3);
            Przestrzen przestrzen2 = new Przestrzen(-4, -5, -6);
            object[] punkty = { prosta1, prosta2, plaszczyzna1, plaszczyzna2, przestrzen1, przestrzen2 };
            double sumaOdległościPłaszczyzny = 0;
            int liczbaPłaszczyzny = 0;
            foreach (var punkt in punkty)
            {
                if (punkt.GetType() == typeof(Plaszczyzna))
                {
                    sumaOdległościPłaszczyzny += ((Plaszczyzna)punkt).Odl_zero();
                    liczbaPłaszczyzny++;
                }
                Console.WriteLine($"Odległość od zera: {((dynamic)punkt).Odl_zero()}");
            }
            double średniaOdległośćPłaszczyzny = sumaOdległościPłaszczyzny / liczbaPłaszczyzny;
            Console.WriteLine($"Średnia odległość punktów na płaszczyźnie od zera: {średniaOdległośćPłaszczyzny}");
        //zadanie 3 (Figury)
            Kolo kolo1 = new Kolo(2, "niebieski", true);
            Kolo kolo2 = new Kolo(5, "czarny", false);
            Prostokat prostokat1 = new Prostokat(4, 6, "czerwony", true);
            Prostokat prostokat2 = new Prostokat(5, 7, "Żółty", false);
            Figura figura1 = new Figura("zielony", true);
            Figura figura2 = new Figura("biały", false);
            object[] figury = { kolo1, kolo2, prostokat1, prostokat2, figura1, figura2 };
            int liczbaKol = 0;
            liczbaKol = Figura.LiczbaElementow<Kolo>(figury);
            Console.WriteLine($"Liczba kół w tablicy: {liczbaKol}");
        }
    }
}