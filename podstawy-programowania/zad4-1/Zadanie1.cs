namespace zaj4;

class Zadanie1
{
    static void Zadanie()
    {
        Console.WriteLine("Podaj gestosc zaludnienia miasta 1");
        double gestoscZaludnienia1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Podaj gestosc zaludnienia miasta 2");
        double gestoscZaludnienia2 = Convert.ToDouble(Console.ReadLine());
        
        double sredniaGestoscZaludnienia = ObliczSredniaGestoscZaludnienia(gestoscZaludnienia1, gestoscZaludnienia2);
        
        Console.WriteLine("Srednia gestosc zaludnienia miast wynosi: " + sredniaGestoscZaludnienia);
    }
    
    private static double ObliczSredniaGestoscZaludnienia(double gestoscZaludnienia1, double gestoscZaludnienia2)
    {
        return (gestoscZaludnienia1 + gestoscZaludnienia2) / 2;
    }
}
