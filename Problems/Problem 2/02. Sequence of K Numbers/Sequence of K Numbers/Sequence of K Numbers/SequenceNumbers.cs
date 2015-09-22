using System;

class SequenceNumbers
{
    static void Main()
    {
        string inputString = Console.ReadLine();
        int k = int.Parse(Console.ReadLine());


            inputString = inputString + " " + int.MaxValue;
        string[] numbers = inputString.Split();
        int eqlauCunter = 1;
        int prev = int.Parse(numbers[0]);
        for (int i = 1; i < numbers.Length; i++)
        {
            int numb = int.Parse(numbers[i]);
            if (numb == prev)
            {
                eqlauCunter++;
            }
            else
            {
                for (int j = 0; j < eqlauCunter % k; j++)
                {
                    Console.Write(prev + " ");
                }
                eqlauCunter = 1;
            }
            prev = numb;
        }

    }
}

