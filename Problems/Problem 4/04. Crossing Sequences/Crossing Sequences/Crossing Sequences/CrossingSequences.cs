using System;

class CrossingSequences
{
    static void Main()
    {
        int max = 1000000;
        int t1 = int.Parse(Console.ReadLine());
        int t2 = int.Parse(Console.ReadLine());
        int t3 = int.Parse(Console.ReadLine());

        bool[] trib = new bool[max + 1];
        trib[t1] = true;
        trib[t2] = true;
        trib[t3] = true;
        while (true)
        {
            int nexT = t3 + t2 + t1;
            if (nexT <= max)
            {
                trib[nexT] = true;
            }
            else
            {
                break;
            }
            t1 = t2;
            t2 = t3;
            t3 = nexT;
        }
        long corner = long.Parse(Console.ReadLine());
        long step = long.Parse(Console.ReadLine());
        bool oddCorner = true;
        long size = 0;
        bool[] spiral = new bool[max + 1];
        while (corner <= max)
        {
            spiral[corner] = true;
            if (oddCorner)
            {
                size += 1;
            }
            corner += size * step;
            oddCorner = !oddCorner;

        }
        for (int i = 1; i <= max; i++)
        {
            if (trib[i] && spiral[i])
            {
                Console.WriteLine(i);
                return;
            }
        }
        Console.WriteLine("No");
    }
}

