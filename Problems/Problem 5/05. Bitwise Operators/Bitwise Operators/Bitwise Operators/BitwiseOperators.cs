using System;

class BitwiseOperators
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n ; i++)
        {
            int p = int.Parse(Console.ReadLine());

            int Pnew = 0;
            while (p > 0)
            {
                Pnew <<= 1;
                if ((p & 1)==1)
                {
                    Pnew |= 1;
                }
                p >>= 1;
            }
            Console.WriteLine(Pnew);
        }

    }
}

