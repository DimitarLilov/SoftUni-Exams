using System;

class HouseWindow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outdot = n - 1;
        int indot = 1;
        Console.WriteLine("{0}*{0}", new string('.', outdot));
        
        for (int i = 1; i < (n); i++)
        {

                Console.WriteLine("{0}*{1}*{0}", new string('.', outdot - i), new string('.', indot));
                indot += 2;
        }
        Console.WriteLine(new string('*', (n*2)-1));
        for (int i = 0; i < n/4; i++)
        {
            Console.WriteLine("*{0}*", new string('.', (n * 2) - 3));
        }
        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine("*{0}{1}{0}*", new string('.',n/2),new string ('*', n-3));
        }
        for (int i = 0; i < (n / 2) / 2; i++)
        {
            Console.WriteLine("*{0}*", new string('.', (n * 2) - 3));
        }
        Console.WriteLine(new string('*', (n * 2) - 1));
    }
}

