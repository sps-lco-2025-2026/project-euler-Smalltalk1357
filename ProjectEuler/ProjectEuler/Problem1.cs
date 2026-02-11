namespace ProjectEuler;

public class Problem1
{
    public static void Run()
    {
        int limit = 1000;
        ulong total = 0;
        
        for (int i = 0; i < limit; i+=3)
            total += (ulong)i;

        for (int j = 0; j < limit; j += 5)
            if (j % 3 != 0)
                total += (ulong)j;
        

        Console.WriteLine(total);
    }
}