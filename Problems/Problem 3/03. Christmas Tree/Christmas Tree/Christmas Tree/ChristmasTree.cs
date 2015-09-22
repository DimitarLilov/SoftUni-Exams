using System;

class ChristmasTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outdots = n;
        int kolibka = 1;
        for (int i = 0; i < (n/2)+1; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('\'', outdots), new string('^', kolibka));
            outdots--;
            kolibka += 2;
        }
        outdots = n-1;
        kolibka = 3;
        for (int i = 0; i < (n/2)+1; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('\'', outdots), new string('^', kolibka));
            outdots--;
            kolibka += 2;
        }
        outdots = n-1;
        for (int i = 0; i < (n/2)+1; i++)
        {
            Console.WriteLine("{0}{1} {1}{0}", new string('\'', outdots), new string('|', 1));
        }
        Console.WriteLine(new string('-', (n*2)+1));
    }
}

