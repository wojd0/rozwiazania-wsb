namespace zad5_7;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // Tworzenie kolekcji Hashtable
        Hashtable rozmiaryKoszulek = new Hashtable();
        rozmiaryKoszulek.Add("LL", "bardzo duża");
        rozmiaryKoszulek.Add("L", "duża");
        rozmiaryKoszulek.Add("M", "średnia");
        rozmiaryKoszulek.Add("S", "mała");
        rozmiaryKoszulek.Add("XS", "bardzo mała");

        // Pobieranie kodu koszulki od użytkownika
        Console.WriteLine("Podaj kod koszulki:");
        string? kodKoszulki = Console.ReadLine()?.ToUpper();

        // Sprawdzanie, czy kodKoszulki nie jest null
        if (kodKoszulki != null && rozmiaryKoszulek.ContainsKey(kodKoszulki))
        {
            Console.WriteLine("Rozmiar koszulki: " + rozmiaryKoszulek[kodKoszulki]);
        }
        else
        {
            Console.WriteLine("Nie znaleziono rozmiaru dla podanego kodu.");
        }
    }
}
