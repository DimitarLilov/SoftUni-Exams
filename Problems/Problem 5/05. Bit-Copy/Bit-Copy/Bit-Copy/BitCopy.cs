using System;

namespace BitCopy
{
    class BitCopy
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            int posToSwap = 2,
                mask = 1;

            // copy bit from position p to mask
            mask &= n >> p;

            // nullify bit at position 2
            n &= ~(1 << posToSwap);

            // copy mask to bit at position 2
            n |= mask << posToSwap;

            Console.WriteLine(n);
        }

    }
}