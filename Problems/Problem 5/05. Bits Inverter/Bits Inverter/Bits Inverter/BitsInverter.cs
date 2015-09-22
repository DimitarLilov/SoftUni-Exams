using System;

class BitsInverter
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int indexer = 0;
        for (int i = 0; i < n; i++)
        {
            int numbers = int.Parse(Console.ReadLine());
            for (int bit = 7; bit >= 0; bit--)
            {
                indexer++;
                if ((step == 1) || (indexer % step == 1))
                {
                    numbers ^= (1 << bit);
                }
            }
            Console.WriteLine(numbers);
        }

    }
}
