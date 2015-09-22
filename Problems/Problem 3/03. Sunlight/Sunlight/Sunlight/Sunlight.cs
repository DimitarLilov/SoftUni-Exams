using System;

class Sunlight
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dots = 3 * n / 2;
        Console.WriteLine("{0}*{0}", new string ('.',dots));
        int outDots = 1;
        int intDots = dots - 2;
        for (int i = 0; i < n-1; i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}", new string ('.',outDots+i), new string ('.',intDots-i));
        }
        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string ('.',n), new string ('*',n));
        }
        Console.WriteLine(new string ('*',3*n));
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
        }
        int outdot = n - 1;
        int indot = n / 2;
        for (int i = 0; i < n-1; i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.',outdot-i), new string ('.',indot+i));
        }
        Console.WriteLine("{0}*{0}", new string('.', dots));
    }
}

