using System;

class DoubleDowns
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int rightDiagonalCounteer =0;
        int leftDiagonalCounteer =0;
        int verticalDiagonalCounteer =0;
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < numbers.Length-1; i++)
        {
            int topNumber = numbers[i];
            int botomNumber = numbers[i + 1];

            for (int bit = 0; bit < 32; bit++)
            {
                int mask = 1 << bit;
                bool checTopBit = (topNumber & mask) > 0;
                if (checTopBit && (botomNumber & (mask>>1)) >0)
                {
                    rightDiagonalCounteer++;
                    
                }
                if (checTopBit && (botomNumber & (mask<<1)) > 0)
                {
                    leftDiagonalCounteer++;
                    
                }
                if (checTopBit && (botomNumber & mask) > 0)
                {
                    verticalDiagonalCounteer++;
                    
                }
                checTopBit = false;
            }

        }
        Console.WriteLine(rightDiagonalCounteer);
        Console.WriteLine(leftDiagonalCounteer);
        Console.WriteLine(verticalDiagonalCounteer);

    }
}

