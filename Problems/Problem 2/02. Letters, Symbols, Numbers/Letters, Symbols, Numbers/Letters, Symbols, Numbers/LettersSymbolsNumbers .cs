using System;
using System.Text.RegularExpressions;

class LettersSymbolsNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long lettersSum = 0;
        long numbersSum = 0;
        long symbolsSum = 0;
        for (int i = 0; i < n; i++)
        {
            string inputLine = Console.ReadLine();
            inputLine = inputLine.ToUpper();
            inputLine = Regex.Replace(inputLine, "\\s+", "");
            for (int j = 0; j < inputLine.Length; j++)
            {
                char currnetChar = inputLine[j];
                if (currnetChar >= 'A' && currnetChar <= 'Z')
                {
                    lettersSum += (currnetChar - 'A' + 1) * 10;

                }
                else if (currnetChar >= '0' && currnetChar <= '9')
                {
                    numbersSum += (currnetChar - '0') * 20;
                }
                else
                {
                    symbolsSum += 200;
                }
            }
        }
        Console.WriteLine(lettersSum);
        Console.WriteLine(numbersSum);
        Console.WriteLine(symbolsSum);
    }
}

