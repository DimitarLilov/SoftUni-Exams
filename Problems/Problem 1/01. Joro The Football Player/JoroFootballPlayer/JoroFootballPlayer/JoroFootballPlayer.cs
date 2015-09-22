using System;

class JoroFootballPlayer
{
    static void Main()
    {
        string yerar = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());

        double totalPlay = ((52 - h) * 2d / 3d + h / 1d + p / 2d);
        if (yerar == "t")
        {
            totalPlay = totalPlay + 3;
        }
        Console.WriteLine((int)totalPlay);




    }
}

