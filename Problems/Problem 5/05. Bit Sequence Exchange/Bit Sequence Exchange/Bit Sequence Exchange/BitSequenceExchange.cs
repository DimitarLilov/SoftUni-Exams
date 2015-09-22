using System;

namespace BitSequenceExchange
{
    class BitSequenceExchange
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            int mask = 7, // 111 in binary
                firstPos = 3,
                secondPos = 24;

            // get the sequences of 3 bits
            long firstThree = n >> firstPos & mask;
            long secondThree = n >> secondPos & mask;

            // nullify three bits at position firstPos
            n &= ~(mask << firstPos);
            // copy secondThree sequence to firstPos
            n |= secondThree << firstPos;

            // nullify three bits at position secondPos
            n &= ~(mask << secondPos);
            // copy firstThree sequence to secondPos
            n |= firstThree << secondPos;

            Console.WriteLine(n);
        }
    }
}
