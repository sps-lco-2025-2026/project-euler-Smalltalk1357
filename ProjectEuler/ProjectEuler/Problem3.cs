namespace ProjectEuler;

public class Problem3
{
    public static void Run()
    {
        const long START = 600851475143;
        
        for (long i = 1; i < START/3; i++)
        {
            if (START % i == 0)
            {
                if (IsPrime(START / i))
                {
                    Console.WriteLine(START / i);
                    return;
                }
            }
        }
    }
    
    private static bool IsPrime(long n)
    {
        if (n <= 1) return false;
        long limit = n / 2;
        for (int i = 2; i <= limit; i++)
            if (n % i == 0) return false;
        return true;
    }
}