using ConsoleApp5;
using System;
using System.Text;
/*
Przerób poniższy program zastępując dwuwymiarową tablicę string[,] kolekcją typu List<Osoba> gdzie osoba to struktura.
byte ile;
Console.WriteLine("ile osób będzie?");
ile = System.Convert.ToByte(Console.ReadLine());
int i = 0;
string[,] tab = new string[ile, 2];
do
{
Console.WriteLine("podaj nazwisko");
tab[i, 0] = Console.ReadLine();
Console.WriteLine("podaj imię");
tab[i, 1] = Console.ReadLine();
i++;
} while (i < ile);
string kto;
Console.WriteLine("czyjego imienia szukasz?");
kto = Console.ReadLine();
for (i = 0; i < ile; i++)
{
if (tab[i, 0] == kto)
Console.WriteLine(tab[i, 1]);
}
Console.ReadKey();
*/
namespace ConsoleApp5
{
    class Program
    {
        //struct do zadania 4
        struct Osoba
        {
            public string Imie;
            public string Nazwisko;
        }
        static void Main(string[] args)
        {
            //zadanie 1 (Ludolfina)
            Obliczenia obliczenia = new Obliczenia();

            ILeibniz leibniz = obliczenia;
            IEuler euler = obliczenia;

            double piLeibniz = leibniz.Ludolfina(20);
            double piEuler = euler.Ludolfina(20);
            double piMath = Math.PI;

            Console.WriteLine("Wynik Leibniza: {0}", piLeibniz);
            Console.WriteLine("Wynik Eulera: {0}", piEuler);
            Console.WriteLine("Wynik Math.PI: {0}", piMath);
            Console.WriteLine("Różnica Leibniza: {0}", Math.Abs(piLeibniz - piMath));
            Console.WriteLine("Różnica Eulera: {0}", Math.Abs(piEuler - piMath));

            //zadanie 2 (Kandydat)
            Kandydat[] kandydaci = new Kandydat[]
            {
                new Kandydat { Nazwisko = "Murarz", PunktyMatematyka = 55, PunktyInformatyka = 44, PunktyJezykObcy = 22 },
                new Kandydat { Nazwisko = "Tynkarz", PunktyMatematyka = 22, PunktyInformatyka = 33, PunktyJezykObcy = 44 },
                new Kandydat { Nazwisko = "Akrobata", PunktyMatematyka = 44, PunktyInformatyka = 11, PunktyJezykObcy = 33 }
            };

            Console.WriteLine("\nLista kandydatów:");
            foreach (var kandydat in kandydaci){
                Console.WriteLine("{0}: {1} punktów", kandydat.Nazwisko, kandydat.ObliczLacznaLiczbePunktow());
            }

            //zadanie 3 (Ścieżka)
            Sciezka.Punkt[] punkty = new Sciezka.Punkt[5];
            for (int i = 0; i < punkty.Length; i++)
            {
                Console.WriteLine("\nPodaj współrzędne punktu {0}:", i + 1);
                Console.Write("x: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("y: ");
                double y = double.Parse(Console.ReadLine());

                punkty[i] = new Sciezka.Punkt(x, y);

                if (i > 0)
                {
                    double odleglosc = punkty[i].Odleglosc(punkty[i - 1]);
                    Console.WriteLine("Odległość między punktem {0} a punktem {1}: {2}", i, i + 1, odleglosc);
                }
            }
            double odlegloscPierwszyOstatni = punkty[0].Odleglosc(punkty[punkty.Length - 1]);
            Console.WriteLine("\nOdległość między pierwszym a ostatnim punktem: {0}", odlegloscPierwszyOstatni);

            //zadanie 4 (Osoby2)
            List<Osoba> osoby = new List<Osoba>();
            Console.WriteLine("\nIle osób chcesz dodać?");
            int ileOsob;
            while (!int.TryParse(Console.ReadLine(), out ileOsob))
            {
                Console.WriteLine("Podaj poprawną liczbę!");
            }
            for (int i = 0; i < ileOsob; i++)
            {
                Console.WriteLine("\nPodaj nazwisko osoby {0}:", i + 1);
                string nazwisko = Console.ReadLine();
                Console.WriteLine("Podaj imię osoby {0}:", i + 1);
                string imie = Console.ReadLine();

                osoby.Add(new Osoba { Nazwisko = nazwisko, Imie = imie });
            }
            Console.WriteLine("\nCzyjego imienia szukasz?");
            string szukaneImie = Console.ReadLine();
            var znalezioneOsoby = osoby.Where(o => o.Imie.Equals(szukaneImie, StringComparison.OrdinalIgnoreCase)).ToList();
            if (znalezioneOsoby.Count > 0)
            {
                Console.WriteLine("Znalezione osoby:");
                foreach (var osoba in znalezioneOsoby)
                {
                    Console.WriteLine("{0} {1}", osoba.Imie, osoba.Nazwisko);
                }
            }
            else
            {
                Console.WriteLine("Nie znaleziono osoby o imieniu {0}.", szukaneImie);
            }
            
        }
    }
}