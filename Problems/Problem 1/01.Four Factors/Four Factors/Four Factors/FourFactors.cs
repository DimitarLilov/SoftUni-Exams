using System;

class FourFactors
{
    static void Main()
    {
        long fg = long.Parse(Console.ReadLine());
        long fga = long.Parse(Console.ReadLine());
        long threP = long.Parse(Console.ReadLine());
        long tov = long.Parse(Console.ReadLine());
        long orb = long.Parse(Console.ReadLine());
        long oppDRB = long.Parse(Console.ReadLine());
        long ft = long.Parse(Console.ReadLine());
        long fta = long.Parse(Console.ReadLine());
        double orboppdrb = orb + oppDRB;
        double resultEFG = (fg + (0.5 * threP)) / fga;
        double resultTOV = tov / (fga + 0.44 * fta + tov);
        double resultORB = (double)orb / orboppdrb;
        double resultFT = (double)ft / fga;

        Console.WriteLine("eFG% {0:f3}", resultEFG);
        Console.WriteLine("TOV% {0:f3}", resultTOV);
        Console.WriteLine("ORB% {0:f3}", resultORB);
        Console.WriteLine("FT% {0:f3}", resultFT);


    }
}

