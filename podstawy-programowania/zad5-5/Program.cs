namespace zad5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tworzenie stosu i dodawanie kolorów
            Stack<string> kolory = new Stack<string>();
            kolory.Push("Niebieski"); // Ulubiony kolor
            kolory.Push("Zielony");
            kolory.Push("Czerwony");
            kolory.Push("Żółty"); 
            kolory.Push("Fioletowy");
            kolory.Push("Pomarańczowy");
            kolory.Push("Różowy");
            kolory.Push("Brązowy"); // Najbrzydszy kolor

            // Usuwanie wszystkich kolorów pozostawiając tylko pierwszy i najbrzydszy
            string najbrzydszy = kolory.Last();
            string ulubiony = kolory.First();

            kolory.Clear();
            kolory.Push(ulubiony);
            kolory.Push(najbrzydszy);

            // Wyświetlanie wyników
            Console.WriteLine("Ulubiony kolor: " + kolory.ElementAt(0));
            Console.WriteLine("Najbrzydszy kolor: " + kolory.ElementAt(1));
        }
    }
}
