using System;

class Illuminati
{
    static void Main()
    {
        string inputstring = Console.ReadLine().ToUpper();
        int numbers = 0;
        int sum = 0;
        foreach (char letter in inputstring)
        {
            if (letter == 'A' || letter == 'U' ||
                letter == 'O' || letter == 'E' || letter == 'I')
            {
                sum += letter;
                numbers++;
            }
        }
        Console.WriteLine(numbers);
        Console.WriteLine(sum);
    }
}

