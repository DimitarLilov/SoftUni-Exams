using System;
using System.Linq;
class WiggleWiggle
{
    static void Main()
    {
        long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();

        for (int i = 0; i < numbers.Length; i+=2)
        {
            for (int j = 0; j < 63; j+=2)
            {
                long mask = 1L << j;
                long currentUpperBit = numbers[i] & mask;

                long currentLowwerBit = numbers[i + 1] & mask;

                numbers[i] &= ~mask;
                numbers[i + 1] &= ~mask;

                numbers[i] |= currentLowwerBit;
                numbers[i + 1] |= currentUpperBit;
            }
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            long mask = long.MaxValue;
            numbers[i] ^= mask;

        }
        foreach (long number in numbers)
        {
            Console.WriteLine("{0} {1}",number,(Convert.ToString(number, 2).PadLeft(63, '0')));
        }
    }
}

