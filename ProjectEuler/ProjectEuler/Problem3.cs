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
                if (Utils.IsPrime(START / i))
                {
                    Console.WriteLine(START / i);
                    return;
                }
            }
        }
    }
}