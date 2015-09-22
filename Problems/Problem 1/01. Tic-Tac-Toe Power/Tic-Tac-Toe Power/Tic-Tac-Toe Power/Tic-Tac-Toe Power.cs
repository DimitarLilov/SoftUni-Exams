using System;

class TicTacToePower
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int firstValue = int.Parse(Console.ReadLine());
        long resultat = 0;
        int position = x + 1;
        if (y == 1)
        {
            position = x + 4;

        }
        else if (y == 2)
        {
            position = x + 7;

        }
        firstValue += position - 1;
        resultat = (long)Math.Pow(firstValue, position);
        Console.WriteLine(resultat);
    }
}

