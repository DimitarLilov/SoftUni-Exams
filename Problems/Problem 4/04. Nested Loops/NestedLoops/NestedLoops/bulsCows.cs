using System;

class BulsCows
{
    static void Main()
    {
        string secretNumber = Console.ReadLine();
        int targetBulls = int.Parse(Console.ReadLine());
        int targetcows = int.Parse(Console.ReadLine());
        bool solutionFound = false;

        for (int canditatNumbers = 1; canditatNumbers <= 9999; canditatNumbers++)
        {
            char[] digits = canditatNumbers.ToString().ToCharArray();
            if (digits.Length == 4 && digits[0] >= '1' &&
                digits[1] >= '1' && digits[2] >= '1' && digits[3] >= '1')
            {
                char[] guess = secretNumber.ToCharArray();
                int bulls = 0;
                int cows = 0;
                for (int i = 0; i < guess.Length; i++)
                {
                    if (digits[i] == guess[i])
                    {
                        bulls++;
                        digits[i] = '*';
                        guess[i] = '@';
                        
                    } 
                }
                for (int guessIndex = 0; guessIndex < guess.Length; guessIndex++)
                {
                    for (int digitsIndex = 0; digitsIndex < digits.Length; digitsIndex++)
                    {
                        if (guess[guessIndex] == digits[digitsIndex])
                        {
                        cows++;
                        digits[digitsIndex] = '*';
                        guess[guessIndex] = '@';
                        
                        }
                    }
                }
                if (bulls == targetBulls && cows == targetcows)
                {
                    if (solutionFound)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(canditatNumbers);
                    solutionFound = true;
                }
            }
        }
        if (!solutionFound)
        {
            Console.WriteLine("No");
        }
    
    }
}

