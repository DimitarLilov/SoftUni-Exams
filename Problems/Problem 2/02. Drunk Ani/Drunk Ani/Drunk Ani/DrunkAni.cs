using System;

class DrunkAni
{
    static void Main()
    {

        long numberOfCabins = long.Parse(Console.ReadLine());
        string command = Console.ReadLine();

        long currentPosition = 0;
        long totalLenghtCovered = 0;

        while (command != "Found a free one!")
        {
            long stepsCount = long.Parse(command);
            long oldPositon = currentPosition;
            currentPosition = (currentPosition + stepsCount) % numberOfCabins;
            long difference = currentPosition - oldPositon;

            if (difference > 0)
            {
                totalLenghtCovered = totalLenghtCovered + Math.Abs(difference);
                Console.WriteLine("Go {0} steps to the right, Ani.", Math.Abs(difference));
            }
            else if (difference < 0)
            {
                totalLenghtCovered = totalLenghtCovered + Math.Abs(difference);
                Console.WriteLine("Go {0} steps to the left, Ani.", Math.Abs(difference));
            }
            else
            {
                totalLenghtCovered = totalLenghtCovered + Math.Abs(difference);
                Console.WriteLine("Stay there, Ani.");
            }
            command = Console.ReadLine();
        }
        Console.WriteLine("Moved a total of {0} steps.", totalLenghtCovered);
    }
}

