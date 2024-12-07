using System;

namespace zad4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double promien = 5.0;
            double bokA = 4.0;
            double bokB = 6.0;
            int liczbaA = 10;
            int liczbaB = 3;

            Console.WriteLine("Pole koła o promieniu {0}: {1}", promien, ObliczPole(promien));
            Console.WriteLine("Pole prostokąta o bokach {0} i {1}: {2}", bokA, bokB, ObliczPole(bokA, bokB));
            Console.WriteLine("Dzielenie zmiennoprzecinkowe {0} przez {1}: {2}", liczbaA, liczbaB, Podziel(liczbaA, liczbaB));
            Console.WriteLine("Dzielenie stałoprzecinkowe {0} przez {1}: {2}", liczbaA, liczbaB, Podziel(liczbaA, liczbaB, true));
        }

        static double ObliczPole(double promien)
        {
            return Math.PI * promien * promien;
        }

        static double ObliczPole(double bokA, double bokB)
        {
            return bokA * bokB;
        }

        static double Podziel(int a, int b)
        {
            return (double)a / b;
        }

        static int Podziel(int a, int b, bool staloPrzecinkowo)
        {
            if (staloPrzecinkowo)
            {
                return a / b;
            }
            else
            {
                return (int)((double)a / b);
            }
        }
    }
}