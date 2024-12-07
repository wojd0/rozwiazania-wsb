using System;
using System.Diagnostics;

namespace Zad4_4
{
    class Program
    {
        static long liczbaWywolan = 0;

        static void Main(string[] args)
        {
            for (int i = 3; i <= 48; i += 3)
            {
                liczbaWywolan = 0;
                Stopwatch stoper = Stopwatch.StartNew();
                long wynik = Fibonacci(i);
                stoper.Stop();
                TimeSpan czas = stoper.Elapsed;
                string czasWykonania = String.Format("{0:00}-{1:00}", czas.Minutes, czas.Seconds);
                Console.WriteLine($"Fibonacci({i}) = {wynik}, Wywolania: {liczbaWywolan}, Czas: {czasWykonania}");
            }
        }

        static long Fibonacci(int n)
        {
            liczbaWywolan++;
            if (n <= 1)
                return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}