using System;

namespace MasterMind
{
    class Program
    {
        static void Main(string[] args)
        {
            string gracz;
            string komp = "";
            string wynik = "";
            string tmp;

            Random losuj = new();

            byte i, j, k, n, m;
            int cl, ct;

            for (k = 1; k <= 4; k++)
            {
                int los1 = losuj.Next(1, 7);
                komp += los1.ToString();
            }

            // Do testów:
            Console.WriteLine($"DEBUG: {komp}");

            Console.WriteLine("Odgadnij liczbę wylosowaną przez komputer. Liczba jest czterocyfrowa.");
            Console.WriteLine("Składa się z cyfr od 1 do 6. Cyfry mogą się powtarzać.");
            Console.WriteLine("Masz maksymalnie 15 prób albo klawisz ESC aby zakończyć grę.");
            Console.WriteLine("'x' oznacza cyfrę na właściwym miejscu.");
            Console.WriteLine("'y' oznacza cyfrę występującą w liczbie, ale na złym miejscu.");

            ConsoleKeyInfo key;

            for (i = 1; i <= 15; i++)
            {
                Console.Write(i + " -> ");

                gracz = "";
                wynik = "";

                cl = Console.CursorLeft;
                ct = Console.CursorTop;

                for (j = 1; j <= 4; j++)
                {
                    do
                    {
                        Console.SetCursorPosition(cl, ct);
                        key = Console.ReadKey(true);

                        if (key.Key == ConsoleKey.Escape)
                            return;

                    } while (key.KeyChar < '1' || key.KeyChar > '6');

                    Console.Write(key.KeyChar);

                    gracz += key.KeyChar;

                    cl += 1;
                }

                tmp = komp;

                // Szukanie x
                for (int x = 0; x < 4; x++)
                {
                    if (gracz[x] == tmp[x])
                    {
                        wynik += "x";

                        gracz = gracz.Remove(x, 1);
                        gracz = gracz.Insert(x, "a");

                        tmp = tmp.Remove(x, 1);
                        tmp = tmp.Insert(x, "z");
                    }
                }

                // Szukanie y
                for (n = 0; n < 4; n++)
                {
                    for (m = 0; m < 4; m++)
                    {
                        if (gracz[m] == tmp[n])
                        {
                            wynik += "y";

                            gracz = gracz.Remove(m, 1);
                            gracz = gracz.Insert(m, "a");

                            tmp = tmp.Remove(n, 1);
                            tmp = tmp.Insert(n, "z");

                            break;
                        }
                    }
                }

                Console.Write("  " + wynik);
                Console.WriteLine();

                if (wynik == "xxxx")
                {
                    Console.WriteLine("\nGratulacje! Odgadłeś liczbę!");
                    Console.ReadKey();
                    return;
                }
            }

            Console.WriteLine("\nNiestety, nie udało Ci się odgadnąć liczby.");
            Console.WriteLine($"Wylosowana liczba to: {komp}");
        }
    }
}