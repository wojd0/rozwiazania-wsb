namespace zad5_4
{
    class Program
    {
        static Queue<string> kolejka = new Queue<string>();

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Dodaj osobę do kolejki");
                Console.WriteLine("2. Wyświetl zawartość kolejki");
                Console.WriteLine("3. Opuść kolejkę");
                Console.WriteLine("4. Następny do lekarza PROSZĘ");
                Console.WriteLine("5. Zakończ program");
                Console.Write("Wybierz opcję: ");
                string? opcja = Console.ReadLine();

                if (opcja == null)
                {
                    Console.WriteLine("Nieprawidłowa opcja, spróbuj ponownie.");
                    continue;
                }

                switch (opcja)
                {
                    case "1":
                        DodajOsobe();
                        break;
                    case "2":
                        WyswietlZawartosc();
                        break;
                    case "3":
                        OpuscKolejke();
                        break;
                    case "4":
                        NastepnyDoLekarzaPROSZE();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowa opcja, spróbuj ponownie.");
                        break;
                }
            }
        }

        static void DodajOsobe()
        {
            Console.Clear();
            Console.Write("Podaj imię osoby: ");
            string? imie = Console.ReadLine();

            if (string.IsNullOrEmpty(imie))
            {
                Console.WriteLine("Imię nie może być puste.");
                return;
            }

            kolejka.Enqueue(imie);
            Console.WriteLine($"{imie} dodany(a) do kolejki.");
        }

        static void WyswietlZawartosc()
        {
            Console.Clear();
            if (kolejka.Count > 0)
            {
                Console.WriteLine("Zawartość kolejki:");
                foreach (var osoba in kolejka)
                {
                    Console.WriteLine(osoba);
                }
            }
            else
            {
                Console.WriteLine("Kolejka jest pusta.");
            }
        }

        static void OpuscKolejke()
        {
            Console.Clear();
            Console.Write("Podaj imię osoby, która chce opuścić kolejkę: ");
            string? imie = Console.ReadLine();

            if (string.IsNullOrEmpty(imie))
            {
                Console.WriteLine("Imię nie może być puste.");
                return;
            }

            if (kolejka.Contains(imie))
            {
                var tempQueue = new Queue<string>();
                while (kolejka.Count > 0)
                {
                    var osoba = kolejka.Dequeue();
                    if (osoba != imie)
                    {
                        tempQueue.Enqueue(osoba);
                    }
                }
                kolejka = tempQueue;
                Console.WriteLine($"{imie} opuścił(a) kolejkę.");
            }
            else
            {
                Console.WriteLine($"{imie} nie znajduje się w kolejce.");
            }
        }

        static void NastepnyDoLekarzaPROSZE()
        {
            Console.Clear();
            if (kolejka.Count > 0)
            {
                string nastepny = kolejka.Dequeue();
                Console.WriteLine($"{nastepny}, proszę do lekarza.");
            }
            else
            {
                Console.WriteLine("Kolejka jest pusta.");
            }
        }
    }
}
