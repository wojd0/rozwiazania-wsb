using System.Collections;

namespace zad5_3;

class Program
{
    static void Main(string[] args)
    {
        ArrayList owoce = new ArrayList();
        ArrayList kwoty = new ArrayList();

        // Dodaj nazwy owoców
        owoce.Add("Jabłko");
        owoce.Add("Banan");
        owoce.Add("Pomarańcza");

        // Dodaj kwoty do zapłaty
        kwoty.Add(2.5);
        kwoty.Add(3.0);
        kwoty.Add(4.75);

        // Oblicz sumę wydanych pieniędzy
        double suma = 0;
        foreach (double kwota in kwoty)
        {
            suma += kwota;
        }

        Console.WriteLine("Suma wydanych pieniędzy na owoce: " + suma);
    }
}
