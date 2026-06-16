namespace WypozyczalniaRowerow
{
    internal class Program
    {
        static WypozyczalniaMain wypozyczalnia = new WypozyczalniaMain();

        static void Main(string[] args)
        {
            bool koniec = false;

            while (!koniec)
            {
                Console.Clear();

                WyswietlMenu();

                string wybor = Console.ReadLine();

                switch (wybor)
                {
                    case "1":
                        Console.Clear();
                        PokazRowery(wypozyczalnia);
                        Pauza();
                        break;

                    case "2":
                        Console.Clear();
                        PokazDostepneRowery(wypozyczalnia);
                        Pauza();
                        break;

                    case "3":
                        DodajRower(wypozyczalnia);
                        break;

                    case "4":
                        UsunRower(wypozyczalnia);
                        break;

                    case "5":
                        WypozyczRower(wypozyczalnia);
                        break;

                    case "6":
                        ZwrocRower(wypozyczalnia);
                        break;

                    case "7":
                        Console.Clear();
                        PokazHistorie(wypozyczalnia);
                        Pauza();
                        break;

                    case "8":
                        Console.Clear();
                        PokazPrzychod(wypozyczalnia);
                        Pauza();
                        break;

                    case "0":
                        koniec = true;
                        break;

                    default:
                        Console.WriteLine("Nieprawidłowa opcja.");
                        Pauza();
                        break;
                }
            }
            static void WyswietlMenu()
            {
                Console.WriteLine("===== WYPOŻYCZALNIA ROWERÓW =====");
                Console.WriteLine("1. Wyświetl wszystkie rowery");
                Console.WriteLine("2. Wyświetl dostępne rowery");
                Console.WriteLine("3. Dodaj rower");
                Console.WriteLine("4. Usuń rower");
                Console.WriteLine("5. Wypożycz rower");
                Console.WriteLine("6. Zwróć rower");
                Console.WriteLine("7. Historia wypożyczeń");
                Console.WriteLine("8. Pokaż przychód");
                Console.WriteLine("0. Wyjście");
                Console.Write("\nTwój wybór: ");
            }

            static void Pauza()
            {
                Console.WriteLine();
                Console.WriteLine("Naciśnij dowolny klawisz...");
                Console.ReadKey();
            }
            //case1
            static void PokazRowery(WypozyczalniaMain wypozyczalnia)
            {
                List<Rower> rowery = wypozyczalnia.PobierzRowery();

                if (rowery.Count == 0)
                {
                    Console.WriteLine("Brak rowerów.");
                    return;
                }

                foreach (Rower rower in rowery)
                {
                    Console.WriteLine(rower);
                }
            }
            //case2
            static void PokazDostepneRowery(WypozyczalniaMain wypozyczalnia)
            {
                List<Rower> rowery = wypozyczalnia.PobierzDostepneRowery();

                if (rowery.Count == 0)
                {
                    Console.WriteLine("Brak dostępnych rowerów.");
                    return;
                }

                foreach (Rower rower in rowery)
                {
                    Console.WriteLine(rower);
                }
            }
            //case3
            static void DodajRower(WypozyczalniaMain wypozyczalnia)
            {
                Console.WriteLine("=== Dodawanie roweru ===");

                int wybor;

                while (true)
                {
                    Console.WriteLine("Typ roweru:");
                    Console.WriteLine("1. Górski");
                    Console.WriteLine("2. Miejski");
                    Console.WriteLine("3. Elektryczny");
                    Console.WriteLine("0. Powrót do menu");

                    Console.Write("Wybór: ");

                    if (!int.TryParse(Console.ReadLine(), out wybor))
                    {
                        Console.WriteLine("Podaj poprawną liczbę.");
                        continue;
                    }

                    if (wybor == 0)
                        return;

                    if (wybor >= 1 && wybor <= 3)
                        break;

                    Console.WriteLine("Niepoprawny wybór.");
                }

                TypRower typ = (TypRower)(wybor - 1);

                string marka;

                do
                {
                    Console.Write("Marka: ");
                    marka = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(marka))
                        Console.WriteLine("Marka nie może być pusta.");

                } while (string.IsNullOrWhiteSpace(marka));

                string model;

                do
                {
                    Console.Write("Model: ");
                    model = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(model))
                        Console.WriteLine("Model nie może być pusty.");

                } while (string.IsNullOrWhiteSpace(model));

                decimal cenaGodzina;

                while (true)
                {
                    Console.Write("Cena za godzinę: ");

                    if (decimal.TryParse(Console.ReadLine(), out cenaGodzina) && cenaGodzina > 0)
                        break;

                    Console.WriteLine("Podaj poprawną cenę.");
                }

                decimal cenaDoba;

                while (true)
                {
                    Console.Write("Cena za dobę: ");

                    if (decimal.TryParse(Console.ReadLine(), out cenaDoba) && cenaDoba > 0)
                        break;

                    Console.WriteLine("Podaj poprawną cenę większą od 0.");
                }

                Rower rower = new Rower(
                    typ,
                    marka,
                    model,
                    cenaGodzina,
                    cenaDoba);

                wypozyczalnia.DodajRower(rower);

                Console.WriteLine();
                Console.WriteLine("Rower został dodany.");
            }
            //case4
            static void UsunRower(WypozyczalniaMain wypozyczalnia)
            {
                while (true)
                {
                    Console.Clear();
                    PokazRowery(wypozyczalnia);

                    Console.WriteLine();
                    Console.WriteLine("Podaj ID roweru do usunięcia (0 - powrót):");

                    if (!int.TryParse(Console.ReadLine(), out int id))
                    {
                        Console.WriteLine("Niepoprawna wartość.");
                        Pauza();
                        continue;
                    }

                    if (id == 0)
                        return;

                    if (wypozyczalnia.UsunRower(id))
                    {
                        Console.WriteLine("Rower został usunięty.");
                        return;
                    }

                    Console.WriteLine("Nie znaleziono roweru o podanym ID lub rower jest aktualnie wypożyczony.");
                    Pauza();
                }
            }
            //case5
            static void WypozyczRower(WypozyczalniaMain wypozyczalnia)
            {
                Console.WriteLine("=== Wypożycz rower ===");
                Console.WriteLine();

                PokazDostepneRowery(wypozyczalnia);

                if (wypozyczalnia.PobierzDostepneRowery().Count == 0)
                {
                    Console.WriteLine("\nBrak dostępnych rowerów.");
                    return;
                }

                int id;

                while (true)
                {
                    Console.Write("\nPodaj ID roweru (0 - powrót): ");

                    if (!int.TryParse(Console.ReadLine(), out id))
                    {
                        Console.WriteLine("Podaj poprawną liczbę.");
                        continue;
                    }

                    if (id == 0)
                        return;

                    Rower rower = wypozyczalnia.ZnajdzRower(id);

                    if (rower == null)
                    {
                        Console.WriteLine("Nie znaleziono roweru.");
                        continue;
                    }

                    if (!rower.CzyDostepny())
                    {
                        Console.WriteLine("Rower jest już wypożyczony.");
                        continue;
                    }

                    Console.Write("Imię klienta: ");
                    string imie = Console.ReadLine();

                    Console.Write("Nazwisko klienta: ");
                    string nazwisko = Console.ReadLine();

                    Console.Write("Telefon: ");
                    string telefon = Console.ReadLine();

                    Klient klient = new Klient(imie, nazwisko, telefon);

                    int rodzaj;

                    while (true)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Rodzaj wypożyczenia:");
                        Console.WriteLine("1. Godzinowe");
                        Console.WriteLine("2. Dobowe");

                        Console.Write("Wybór: ");

                        if (int.TryParse(Console.ReadLine(), out rodzaj) &&
                            (rodzaj == 1 || rodzaj == 2))
                            break;

                        Console.WriteLine("Niepoprawny wybór.");
                    }

                    Wypozyczenie wypozyczenie;

                    if (rodzaj == 1)
                    {
                        int godziny;

                        while (true)
                        {
                            Console.Write("Liczba godzin: ");

                            if (int.TryParse(Console.ReadLine(), out godziny) && godziny > 0)
                                break;

                            Console.WriteLine("Podaj poprawną liczbę.");
                        }

                        wypozyczenie = new WypozyczenieGodzinowe(
                            klient,
                            rower,
                            godziny);
                    }
                    else
                    {
                        int dni;

                        while (true)
                        {
                            Console.Write("Liczba dni: ");

                            if (int.TryParse(Console.ReadLine(), out dni) && dni > 0)
                                break;

                            Console.WriteLine("Podaj poprawną liczbę.");
                        }

                        wypozyczenie = new WypozyczenieDobowe(
                            klient,
                            rower,
                            dni);
                    }

                    wypozyczalnia.WypozyczRower(wypozyczenie);

                    Console.WriteLine();
                    Console.WriteLine($"Koszt wypożyczenia: {wypozyczenie.ObliczKoszt():C}");
                    Console.WriteLine("Rower został wypożyczony.");

                    return;
                }
            }
            //case6
            static void ZwrocRower(WypozyczalniaMain wypozyczalnia)
            {
                Console.WriteLine("=== Zwrot roweru ===");
                Console.WriteLine();

                PokazRowery(wypozyczalnia);

                while (true)
                {
                    Console.Write("\nPodaj ID roweru (0 - powrót): ");

                    if (!int.TryParse(Console.ReadLine(), out int id))
                    {
                        Console.WriteLine("Podaj poprawną liczbę.");
                        continue;
                    }

                    if (id == 0)
                        return;

                    if (wypozyczalnia.ZwrocRower(id))
                    {
                        Console.WriteLine("Rower został zwrócony.");
                        return;
                    }

                    Console.WriteLine("Nie można zwrócić tego roweru.");
                }
            }
            //case7
            static void PokazHistorie(WypozyczalniaMain wypozyczalnia)
            {
                List<Wypozyczenie> historia = wypozyczalnia.PobierzHistorie();

                if (historia.Count == 0)
                {
                    Console.WriteLine("Historia wypożyczeń jest pusta.");
                    return;
                }

                foreach (Wypozyczenie wypozyczenie in historia)
                {
                    Console.WriteLine(wypozyczenie);
                    Console.WriteLine("-----------------------------------");
                }
            }
            //case8
            static void PokazPrzychod(WypozyczalniaMain wypozyczalnia)
            {
                Console.WriteLine($"Łączny przychód wypożyczalni: {wypozyczalnia.ObliczPrzychod():C}");
            }
        }
    }
}