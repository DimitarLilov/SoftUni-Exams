using System;

class Summertime
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}", new string(' ', n/2), new string('*', n+1));
        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string(' ', (n/2)), new string(' ', (n-1)));
        }
        int indot = n - 2;
        for (int i = 0; i < n / 2; i++)
        {

            Console.WriteLine("{0}*{1}*{0}", new string(' ', (n / 2) -i), new string(' ', indot+1));
            indot += 2;
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("*{0}*", new string('.', (n * 2) -2));
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("*{0}*", new string('@', (n * 2) - 2));
        }
        Console.WriteLine("{0}",new string('*',n*2));
    }
}

