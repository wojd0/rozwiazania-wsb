namespace zad4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = [5, 3, 8, 1, 9, 2, 7, 4, 6, 0];
            int najmniejszyElement = ZnajdzNajmniejszyElement(tablica);
            Console.WriteLine("Najmniejszy element w tablicy: " + najmniejszyElement);
        }

        static int ZnajdzNajmniejszyElement(int[] tablica)
        {
            int najmniejszy = tablica[0];
            for (int i = 1; i < tablica.Length; i++)
            {
                if (tablica[i] < najmniejszy)
                {
                    najmniejszy = tablica[i];
                }
            }
            return najmniejszy;
        }
    }
}