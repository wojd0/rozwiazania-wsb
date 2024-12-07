namespace zaj4;

public class Program
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 20; i++)
            Console.WriteLine(SumaOd1(i));
    }

    private static int SumaOd1(int n)
    {
        int agg = 0;
        
        for (int i = 0; i <= n; i++)
            agg += i;
        
        return agg;
    }
}