using System;

class Gambling
{
    static void Main()
    {
        decimal cash = decimal.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split();
        int sumCard = 0;
        int cauntWining = 0;
        int totalcaunt = 0;
        foreach (var card in input)
        {
            switch (card)
            {
                case "J": sumCard += 11;
                    break;
                case "Q": sumCard += 12;
                    break;
                case "K": sumCard += 13;
                    break;
                case "A": sumCard += 14;
                    break;
                default: sumCard += int.Parse(card);
                    break;
            } 
        }
        for (int card1 = 2; card1 < 15; card1++)
        {
            for (int card2 = 2; card2 < 15; card2++)
            {
                for (int card3 = 2; card3 < 15; card3++)
                {
                    for (int card4 = 2; card4 < 15; card4++)
                    {
                        int myPawer = card1 + card2 + card3 + card4;
                        if (myPawer > sumCard)
                        {
                            cauntWining++;
                        }
                        totalcaunt++;
                    }
                }
            }
        }
        decimal probabilytu = (decimal)cauntWining / totalcaunt;
        if (probabilytu < 0.5m)
        {
            Console.WriteLine("FOLD");
        }
        else
        {
            Console.WriteLine("DRAW");
        }
        decimal expectedWinning = probabilytu * 2 * cash;
        Console.WriteLine("{0:f2}",expectedWinning);
    }
}

