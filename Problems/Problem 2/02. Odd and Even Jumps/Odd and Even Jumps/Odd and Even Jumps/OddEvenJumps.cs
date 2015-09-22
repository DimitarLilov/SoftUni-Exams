using System;

class OddEvenJumps
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower().Replace(" ", "");
        int oddJump = int.Parse(Console.ReadLine());
        int evenJump = int.Parse(Console.ReadLine());
        int oddCunter = 0;
        int oddResult = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (i % 2 == 0)
            {


                oddCunter++;
                if (oddCunter % oddJump == 0)
                {
                    oddResult *= input[i];
                }
                else
                {
                    oddResult += input[i];
                }
            }
        }
        string oddsum = oddResult.ToString("X");
        Console.WriteLine("Odd: "+oddsum);

        int evenCounter = 0;
        ulong evenResult = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (i % 2 != 0)
            {

                evenCounter++;
                if (evenCounter % evenJump == 0)
                {
                    evenResult *= input[i];
                }
                else
                {
                    evenResult += input[i];
                }
            }
        }
        string evenSum = evenResult.ToString("X");
        Console.WriteLine("Even: " + evenSum);
    }
}

