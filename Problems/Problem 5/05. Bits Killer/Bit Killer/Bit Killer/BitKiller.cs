using System;

class BitKiller
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int index =0;
        int outputBits =0 ;
        int outputBitsCunter=0;
        for (int i = 0; i < n; i++)
        {
            int numb = int.Parse(Console.ReadLine());
            for (int bitIndex = 7; bitIndex >=0; bitIndex--)
            {
                if (!((index % step == 1)||(step == 1 && index >0)))
                {
                    int bitValue = (numb >> bitIndex) & 1;
                    outputBits = outputBits << 1;
                    outputBits = outputBits | bitValue;
                    outputBitsCunter++;
                    if (outputBitsCunter == 8)
                    {
                        Console.WriteLine(outputBits);
                        outputBits = 0;
                        outputBitsCunter = 0;
                    }
                }
                index++;
            }
        }
        if (outputBitsCunter > 0)
        {
            outputBits = outputBits << (8 - outputBitsCunter);
            Console.WriteLine(outputBits);
        }

    }
}

