using System;

class Volleyball
{
    static void Main()
    {
        string year = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine());
        int hometown = int.Parse(Console.ReadLine());

        int weekend = 48;
        double normalplay = (weekend - hometown) * 3.0 / 4.0;
        double holidayplay = holidays * 2.0 / 3.0;
        double total = (hometown * 1.0) + normalplay + holidayplay;
        if (year == "leap")
        {
            total = total * 1.15d;

        }
        Console.WriteLine((int)total);
    }
}

