using System;

class BasketBattle
{
    static void Main()
    {
        string First = Console.ReadLine();
        int rounds = int.Parse(Console.ReadLine());
        bool simeonFirst = false;
        bool nakovFirst = false;
        int simeonPoints = 0;
        int nakovPoints = 0;
        string winer = "";
        int winround = 0;
        if (First == "Simeon")
        {
            simeonFirst = true;
        }
        else if (First == "Nakov")
        {
            nakovFirst = true;
        }
        for (int round = 1; round <= rounds; round++)
        {
            int firstPoint = int.Parse(Console.ReadLine());
            string firstSuccesful = Console.ReadLine();
            if (simeonFirst)
            {
                if (firstSuccesful == "success" && simeonPoints + firstPoint <= 500)
                {
                    simeonPoints += firstPoint;
                }
                if (simeonPoints == 500)
                {
                    winer = "Simeon";
                    winround = round;
                    break;
                }
                int secondPoints = int.Parse(Console.ReadLine());
                string secondSuccesful = Console.ReadLine();
                if (secondSuccesful == "success" && nakovPoints + secondPoints <=500)
                {
                    nakovPoints += secondPoints;
                }
                if (nakovPoints == 500)
	            {
                    winer = "Nakov";
                    winround = round;
                    break;
	            }
            }
            if (nakovFirst)
            {
                if (firstSuccesful == "success" && nakovPoints + firstPoint <=500)
                {
                    nakovPoints += firstPoint;
                }
                if (nakovPoints ==500)
                {
                    winer = "Nakov";
                    winround = round;
                    break;
                }
                int secondPoints = int.Parse(Console.ReadLine());
                string secondSuccsesful = Console.ReadLine();
                if (secondSuccsesful == "success" && simeonPoints + secondPoints <= 500)
                {
                    simeonPoints += secondPoints;
                }
                if (simeonPoints == 500)
                {
                    winer = "Simeon";
                    winround = round;
                    break;
                }
            }
            simeonFirst = !simeonFirst;
            nakovFirst = !nakovFirst;
        
        
        }
        if (winer == "Simeon")
        {
            Console.WriteLine(winer);
            Console.WriteLine(winround);
            Console.WriteLine(nakovPoints);
        }
        else if (winer == "Nakov")
        {
            Console.WriteLine(winer);
            Console.WriteLine(winround);
            Console.WriteLine(simeonPoints);
        }
        else if (winer == "" && nakovPoints == simeonPoints)
        {
            Console.WriteLine("DRAW");
            Console.WriteLine(simeonPoints);
        }
        else
        {
            if (simeonPoints > nakovPoints)
            {
                Console.WriteLine("Simeon");
                Console.WriteLine(simeonPoints - nakovPoints);
            }
            else
            {
                Console.WriteLine("Nakov");
                Console.WriteLine(nakovPoints - simeonPoints);
            }
        }



    }
}

