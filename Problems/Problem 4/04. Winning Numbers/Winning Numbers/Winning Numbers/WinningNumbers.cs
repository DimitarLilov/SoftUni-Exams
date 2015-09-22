using System;

class WinningNumbers
{
    static void Main()
    {
        string input = Console.ReadLine().ToUpper();
        int sum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            int position = input[i];
            int suminput = position - 64;
            sum += suminput;
        }
        int counter = 0;
        for (int c1 = 0; c1 <= 9; c1++)
        {
            for (int c2 = 0; c2 <= 9; c2++)
            {
                for (int c3 = 0; c3 <= 9; c3++)
                {
                    int sumf = c1 * c2 * c3;
                    for (int c4 = 0; c4 <= 9; c4++)
                    {
                        for (int c5 = 0; c5 <= 9; c5++)
                        {
                            for (int c6 = 0; c6 <= 9; c6++)
                            {
                                int sums = c4 * c5 * c6;
                                if (sumf == sums && sumf == sum && sums == sum)
                                {
                                    Console.WriteLine(c1 + "" + c2 + "" + c3 + '-' + c4 + "" + c5 + "" + c6);
                                    counter++;
                                }
                            }
                        }
                    }
                }
            }
        }
        if (counter == 0)
        {
            Console.WriteLine("No");
        }
    }
}
