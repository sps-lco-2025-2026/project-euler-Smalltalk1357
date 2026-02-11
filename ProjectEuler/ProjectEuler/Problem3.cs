namespace ProjectEuler;

public class Problem3
{
    public static void Run()
    {
        
    }
    
    private static bool isPrime(int n)
    {
        if (n <= 1) return false;
        int limit = n / 2;
        
        for (int i = 2; i <= limit; i++)
            if (n % i == 0) return false;
        
        return true;
    }
}