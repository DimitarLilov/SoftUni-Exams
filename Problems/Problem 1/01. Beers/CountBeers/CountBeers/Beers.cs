using System;

class Beers
{
    static void Main()
    {
        string[] inputString = Console.ReadLine().Split();
        int cunterBeers = 0;

        while (inputString[0] != "End")
        {
            int beer = int.Parse(inputString[0]);
            switch (inputString[1])
            {
                case "stacks":
                    int beers = beer * 20;
                    cunterBeers += beers;
                    break;
                case "beers":
                    cunterBeers += beer;
                    break;
            }
            inputString = Console.ReadLine().Split();

        }
        int stek = cunterBeers / 20;
        int beersSingle = cunterBeers % 20;
        Console.WriteLine("{0} stacks + {1} beers",stek , beersSingle);

    }
}

