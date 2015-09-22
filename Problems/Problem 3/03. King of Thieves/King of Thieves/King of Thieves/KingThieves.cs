using System;

class KingThieves
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char type = Console.ReadLine()[0];
        int intTupe = 1;
        int outDots = n / 2;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('-', outDots), new string(type, intTupe));
            if (n/2>i)
            {
                outDots--;
                intTupe += 2;
            }
            else
            {
                outDots++;
                intTupe -= 2;
            }
        }
        
    }
}

