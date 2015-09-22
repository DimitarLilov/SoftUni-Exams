using System;

class BitFlipper
{
    static void Main()
    {
        ulong input = ulong.Parse(Console.ReadLine());
        int endbit = 62;

        while (endbit > 0)
        {
            endbit--;
            ulong last3bits = (input >> endbit) & 7;
            if (last3bits == 0 || last3bits == 7)
            {
                input ^= (ulong)7 << endbit;
                endbit -= 2;
            }

        }
        Console.WriteLine(input);

    }
}
