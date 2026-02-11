namespace ProjectEuler;

public class Problem2
{
    public static void Run()
    {
        int first = 1;
        int second = 2;
        int sum = 0;
        
        ulong total = 2;
        while (sum < 4_000_000)
        {
            sum = first + second;
            first = second;
            second = sum;
            if (sum % 2 == 0)
                total += (ulong)sum;
        }

        Console.WriteLine(total);
    }
}