using System;

namespace BitExchange
{
    class BitExchange
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            int mask = 1,
                firstPos = 3,
                secondPos = 24;

            // get both bits
            long firstBit = (n >> firstPos) & mask;
            long secondBit = (n >> secondPos) & mask;

            // nullify bit at first position
            n &= ~(mask << firstPos);
            // copy second bit to first position
            n |= secondBit << firstPos;

            // nullify bit at second position
            n &= ~(mask << secondPos);
            // copy first bit to second position
            n |= firstBit << secondPos;

            Console.WriteLine(n);
        }
    }
}
