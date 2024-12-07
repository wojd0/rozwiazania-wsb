namespace zad4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 21; i++)
            {
                Console.WriteLine($"Potęga 2 do {i} = {Silnia(2, i)}");
                Console.WriteLine($"Silnia {i} = {Potęgowanie(i)}");
            }
        }

        static long Silnia(long podstawa, int wykladnik)
        {
            if (wykladnik == 0)
                return 1;
            return podstawa * Silnia(podstawa, wykladnik - 1);
        }

        static long Potęgowanie(int n)
        {
            if (n == 0)
                return 1;
            return n * Potęgowanie(n - 1);
        }
    }
}