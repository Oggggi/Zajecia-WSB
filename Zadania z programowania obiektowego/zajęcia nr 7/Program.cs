using ConsoleApp7;
using System;
using System.Text;

namespace ConsoleApp7
{
    class Program
    {
        //zadanie 1 (Stosy)
        static void OdlozNaStos<T>(Stack<T> stos, List<T> wartosc)
        {
            foreach (T element in wartosc)
            {
                stos.Push(element);
            }
        }

        static void WyswietlElementy<T>(Stack<T> stos)
        {
            foreach (T element in stos)
            {
                Console.Write(element + " ");
            }
        }

        //zadamie 3 (Wątek)
        public static void Blizniaki()
        {
            for (int i = 2; i <= 500; i++)
            {
                bool isPrime1 = true;
                bool isPrime2 = true;

                for (int j = 2; j <= Math.Sqrt(i) || j <= Math.Sqrt(i + 2); j++)
                {
                    if (i % j == 0 && j <= Math.Sqrt(i))
                    {
                        isPrime1 = false; break;
                    }
                    if ((i + 2) % j == 0 && j <= Math.Sqrt(i + 2))
                    {
                        isPrime2 = false; break;
                    }
                }
                if (isPrime1 && isPrime2)
                {
                    Console.WriteLine($"({i}, {i + 2})");
                }
                try
                {
                    Thread.Sleep(100);
                }

                catch
                {
                    return;
                }
            }
            Console.WriteLine("Koniec Blizniakow");
        }
            static void Main(string[] args)
        {
            //zadanie 1 (Stosy)
            Stack<int> stos1 = new Stack<int>();
            List<int> liczby = new List<int> { 1, 2, 3, 4, 5, 6 };
            OdlozNaStos<int>(stos1, liczby);
            Console.WriteLine("Elementy na stosie: ");
            WyswietlElementy<int>(stos1);
            Stack<string> stos2 = new Stack<string>();
            List<string> teksty = new List<string> { "jeden", "dwa", "trzy", "cztery", "pięć" };
            OdlozNaStos<string>(stos2, teksty);
            Console.WriteLine("\nElementy na stosie: ");
            WyswietlElementy<string>(stos2);
            Console.WriteLine("\n\n");

            //zadanie 2 (Personel)
            KlasaPochodna1 pracownik1 = new KlasaPochodna1("John");
            pracownik1.DisplayInfo();
            pracownik1.experience = "average";
            pracownik1.DisplayInfo();
            KlasaPochodna2 pracownik2 = new KlasaPochodna2("Misiek");
            pracownik2.DisplayInfo();
            pracownik2.experience = true;
            pracownik2.DisplayInfo();
            KlasaPochodna1 pracownik3 = new KlasaPochodna1("Antony");
            pracownik3.DisplayInfo();
            pracownik3.experience = "huge";
            pracownik3.DisplayInfo();

            //zadanie 3 (Wątek)
            Thread watek = new Thread(Blizniaki);
            watek.Start();
            int m = 0;
            int su = 0;
            while (m != -1)
            {
                Console.WriteLine("Podaj liczbe > 0 albo przerwij watek (0) albo zakoncz dodawanie (-1): ");
                Thread.Sleep(100);
                m = Convert.ToInt16(Console.ReadLine());
                if (m == 0)
                {
                    watek.Interrupt();
                }
                if(m == -1)
                {
                    break;
                }
                su += m;
            }
            Console.WriteLine("Suma: " + su);
        }
    }
}