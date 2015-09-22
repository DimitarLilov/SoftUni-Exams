using System;

class TravellerBob
{
    static void Main()
    {
        string yaer = Console.ReadLine();
        int contracts = int.Parse(Console.ReadLine());
        int family = int.Parse(Console.ReadLine());

        int contractsTravels = contracts * (4 * 3);
        int familyTravels = ((2 * 2) * family);
        double normalTravels = (((12 - contracts - family) * 12) * 3 / 5.0);
        double total = normalTravels + contractsTravels + familyTravels;
        if (yaer == "leap")
        {
            total = total * 1.05d;
        }

        Console.WriteLine((int)total);


    }
}

