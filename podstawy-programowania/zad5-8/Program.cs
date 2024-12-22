namespace zad5_8;

class Program
{
    static void Main(string[] args)
    {
        // Utwórz listę typu LinkedList
        LinkedList<int> liczby = new LinkedList<int>();
        Random random = new Random();
        
        // Wylosuj 5 liczb z zakresu od 6 do 42
        for (int i = 0; i < 5; i++)
        {
            liczby.AddLast(random.Next(6, 43));
        }

        // Oblicz średnią arytmetyczną
        double suma = 0;
        foreach (int liczba in liczby)
        {
            suma += liczba;
        }
        double srednia = suma / liczby.Count;

        // Wyświetl wylosowane liczby i ich średnią arytmetyczną
        Console.WriteLine("Wylosowane liczby: " + string.Join(", ", liczby));
        Console.WriteLine("Średnia arytmetyczna: " + srednia);
    }
}
