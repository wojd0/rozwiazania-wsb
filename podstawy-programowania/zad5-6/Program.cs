namespace zad5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Tworzenie słownika do przechowywania dat urodzin
            Dictionary<string, DateTime> datyUrodzin = new Dictionary<string, DateTime>();

            // Dodawanie danych do słownika
            DodajDateUrodzin(datyUrodzin, "Smok", new DateTime(2002, 5, 12));
            DodajDateUrodzin(datyUrodzin, "Feniks", new DateTime(2003, 8, 23));
            DodajDateUrodzin(datyUrodzin, "Tygrys", new DateTime(2004, 3, 15));
            DodajDateUrodzin(datyUrodzin, "Smok", new DateTime(2002, 5, 12)); // Przykład dodania istniejącej osoby

            // Wyświetlanie zawartości słownika
            foreach (var item in datyUrodzin)
            {
                Console.WriteLine($"Pseudonim: {item.Key}, Data urodzin: {item.Value.Day} {item.Value.ToString("MMMM")} {item.Value.Year}");
            }
        }

        static void DodajDateUrodzin(Dictionary<string, DateTime> slownik, string pseudonim, DateTime dataUrodzin)
        {
            // Sprawdzanie, czy osoba już istnieje w słowniku
            if (slownik.ContainsKey(pseudonim))
            {
                Console.WriteLine($"Osoba o pseudonimie {pseudonim} już istnieje w słowniku.");
            }
            else
            {
                slownik[pseudonim] = dataUrodzin;
                Console.WriteLine($"Dodano osobę o pseudonimie {pseudonim} z datą urodzin {dataUrodzin.ToShortDateString()}.");
            }
        }
    }
}
