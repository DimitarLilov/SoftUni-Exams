using System;

class Dumbbell
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int indots = n / 2;
        int asterix = n / 2;
        Console.WriteLine("{0}{1}{2}{1}{0}", new string ('.',indots), new string('&',n - (indots)), new string ('.',n));
        for (int i = 1; i < n/2; i++)
        {
            Console.WriteLine("{0}&{1}&{2}&{1}&{0}", new string('.', indots - i), new string('*', asterix), new string('.', n));
            asterix++;
        }
        Console.WriteLine("&{0}&{1}&{0}&", new string ('*', n -2), new string ('=',n));
        asterix--;
        for (int i = 1; i < n/2; i++)
        {
            Console.WriteLine("{0}&{1}&{2}&{1}&{0}", new string('.', i), new string('*', asterix), new string('.', n));

            asterix--;
        }
        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', indots), new string('&', n - (indots)), new string('.', n));
    }
}

