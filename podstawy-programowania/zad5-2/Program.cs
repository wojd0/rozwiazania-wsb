namespace zad5_2;

class Program
{
    static void Main(string[] args)
    {
        // Tworzenie kolekcji generycznej imion typu HashSet
        HashSet<string> imiona = new HashSet<string>();

        // Dodawanie imion zaczynających się od litery "A"
        string[] imionaDoDodania = { "Anna", "Agnieszka", "Andrzej", "Alicja", "Artur", "Anna", "Agnieszka", "Adam", "Aleksander", "Alicja", "Amelia", "Aneta", "Arkadiusz", "Aurelia", "Antoni", "Agnieszka", "Anna" };
        foreach (string imie in imionaDoDodania)
        {
            imiona.Add(imie);
        }

        // Wyświetlanie liczby unikatowych imion
        Console.WriteLine("Liczba unikatowych imion: " + imiona.Count);
    }
}
