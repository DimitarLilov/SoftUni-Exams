using System;

class XBits
{
    static void Main()
    {
        int[] numbers = new int [8];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int counter = 0;
        for (int i = 0; i < numbers.Length -2; i++)
        {
            for (int j = 0; j < 32; j++)
            {
                bool up = ((numbers[i] >> j) & 7) == 5;
                bool midd = ((numbers[i + 1] >> j) & 7) == 2;
                bool down = ((numbers[i + 2] >> j) & 7) == 5;
                if (up && midd & down)
                {
                    counter++;
                }
            }
        }
        Console.WriteLine(counter);
    }
}

