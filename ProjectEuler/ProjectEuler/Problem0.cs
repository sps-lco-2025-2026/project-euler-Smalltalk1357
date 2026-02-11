namespace ProjectEuler;

public class Problem0
{
    public static void Run()
    {
        ulong total = 0;
        
        for (int i = 1; i < 559000; i += 2)
        {
            total += (ulong)Math.Pow(i, 2);
        }
        
        Console.WriteLine(total);
    }
}