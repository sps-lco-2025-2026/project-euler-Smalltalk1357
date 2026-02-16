namespace ProjectEuler;

public class Utils
{
    public static void Run()
    {
        List<int> primes = GeneratePrimes(30);
        foreach (int prime in primes) Console.WriteLine(prime);
    }
    
    public static bool IsPrime(long n)
    {
        if (n <= 1) return false;
        long limit = n / 2;
        for (int i = 2; i <= limit; i++)
            if (n % i == 0) return false;
        return true;
    }
    
    public static List<int> GeneratePrimes(int limit)
    {
        // Sieve of Atkin
        bool[] numList = new bool[limit + 1];
        
        if (limit > 2) numList[2] = true;
        if (limit > 3) numList[3] = true;

        for (int i = 1; i * i <= limit; i++)
        {
            for (int j = 1; j * j <= limit; j += 1)
            {
                int n = (4 * i * i) + (j * j);
                if (n <= limit && (n % 12 == 1 || n % 12 == 5))
                    numList[n] = !numList[n];
                
                n = (3 * i * i) + (j * j);
                if (n <= limit && n % 12 == 7)
                    numList[n] = !numList[n];
                
                n = (3 * i * i) - (j * j);
                if (i > j && n <= limit && n % 12 == 11)
                    numList[n] = !numList[n];
            }
        }

        List<int> primes = [];
        for (int i = 2; i <= limit; i++)
        {
            if (numList[i]) primes.Add(i);
        }

        return primes;
    }
}