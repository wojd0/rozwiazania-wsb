using System;

namespace zad4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = [5, 3, 8, 4, 2];

            SortowanieBabelkowe(tablica);

            Console.WriteLine("Posortowana tablica:");
            foreach (int liczba in tablica)
            {
                Console.Write(liczba + " ");
            }
        }

        static void Zamien(ref int a, ref int b)
        {
            (a, b) = (b, a);
        }

        static void SortowanieBabelkowe(int[] tablica)
        {
            int n = tablica.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (tablica[j] > tablica[j + 1])
                    {
                        Zamien(ref tablica[j], ref tablica[j + 1]);
                    }
                }
            }
        }
    }
}