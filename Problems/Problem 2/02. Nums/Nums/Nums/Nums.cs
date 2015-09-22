using System;

class Nums
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        for (int i = n; i <= m; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("{0:F3}", (double)Math.Sqrt(i));
            }
            else if (i % 2 != 0)
            {
                Console.WriteLine("{0:F3}",Math.Pow(i, 2));
            }
        }
    }
}

