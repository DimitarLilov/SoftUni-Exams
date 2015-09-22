using System;

class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}*{0}", new string('.', n / 2));
        for (int i = 1; i < (n / 2); i++)
        {
            if (i == 1)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', (n / 2) - i), new string('.', i));
            }
            else
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', (n / 2) - i), new string('.', i + i - 1));
            }
        }
        Console.WriteLine("{0}", new string('*', n));
        int outdot = (int)(n / 2) / 2;
        int indot = (int)(n - (outdot + outdot) - 2);
        for (int j = 1; j < (n / 2); j++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outdot), new string('.', indot));
        }
        Console.WriteLine("{0}*{1}*{0}", new string('.', (n / 2) / 2), new string('*', (n - (outdot + outdot) - 2)));
    }
}

