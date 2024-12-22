namespace zad5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> oceny = new List<double>();
            string? wejscie; // Zmieniono na nullable
            Console.WriteLine("Wprowadź oceny (wpisz 'koniec' aby zakończyć):");

            while (true)
            {
                wejscie = Console.ReadLine();
                if (wejscie == null) // Sprawdzenie null
                {
                    Console.WriteLine("Nieprawidłowe dane. Proszę wprowadzić prawidłową ocenę.");
                    continue;
                }

                if (wejscie.ToLower() == "koniec")
                    break;

                if (SprobujParsowacOcene(wejscie, out double ocena))
                {
                    oceny.Add(ocena);
                }
                else
                {
                    Console.WriteLine("Nieprawidłowe dane. Proszę wprowadzić prawidłową ocenę.");
                }
            }

            if (oceny.Count > 2)
            {
                oceny.Remove(oceny.Max());
                oceny.Remove(oceny.Min());

                double srednia = oceny.Average();
                double ocenaSemestralna = PrzeliczNaOcene(srednia);
                Console.WriteLine($"Średnia ocen to: {srednia}");
                Console.WriteLine($"Ocena semestralna to: {ocenaSemestralna}");
            }
            else
            {
                Console.WriteLine("Za mało ocen, aby obliczyć ocenę semestralną.");
            }
        }

        static bool SprobujParsowacOcene(string wejscie, out double ocena)
        {
            ocena = 0;
            if (double.TryParse(wejscie, out ocena))
            {
                return true;
            }

            if (wejscie.EndsWith("+") || wejscie.EndsWith("-"))
            {
                string bazaOcenyStr = wejscie.Substring(0, wejscie.Length - 1);
                if (double.TryParse(bazaOcenyStr, out double bazaOceny))
                {
                    if (wejscie.EndsWith("+"))
                    {
                        ocena = bazaOceny + 0.5;
                    }
                    else if (wejscie.EndsWith("-"))
                    {
                        ocena = bazaOceny - 0.25;
                    }
                    return true;
                }
            }

            return false;
        }

        static double PrzeliczNaOcene(double srednia)
        {
            if (srednia >= 4.75) return 5.0;
            if (srednia >= 4.25) return 4.5;
            if (srednia >= 3.75) return 4.0;
            if (srednia >= 3.25) return 3.5;
            if (srednia >= 2.75) return 3.0;
            if (srednia >= 2.25) return 2.5;
            return 2.0;
        }
    }
}
