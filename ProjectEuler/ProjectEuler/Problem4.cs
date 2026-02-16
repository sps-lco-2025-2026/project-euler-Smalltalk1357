namespace ProjectEuler;

public class Problem4
{
    public static void Run()
    {
        for (int i = 999; i > 800; i--)
        {
            for (int j = 999; j > 800; j--)
            {
                string temp = (i * j).ToString();
                if ((temp[0] == temp[5]) && (temp[1] == temp[4]) && (temp[2] == temp[3]))
                {
                    Console.WriteLine(temp);
                }
            }
        }
    }
}