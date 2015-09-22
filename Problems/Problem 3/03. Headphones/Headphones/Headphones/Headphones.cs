using System;

class Headphones
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int asterix = n + 2;
        Console.WriteLine("{0}{1}{0}", new string('-', n/2), new string('*', asterix));
        for (int i = 0; i < n-1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('-', n/2), new string('-', n));
        }
        int inasterix = 1;
        int inspace = n;
        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}",new string('-', (n/2)-i),new string('*',inasterix),new string ('-',inspace));
            inasterix += 2;
            inspace -= 2;
        }

        Console.WriteLine("{0}-{0}",new string('*',n));
        int inasterix2 = n;
        int inspace2 = 3;
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', 1 + i), new string('*', inasterix2-2), new string('-', inspace2));
            inasterix2 -= 2;
            inspace2 += 2;
        }
    }
}

