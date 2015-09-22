using System;

class Electricity
{
    static void Main()
    {
        int floors = int.Parse(Console.ReadLine());
        int flats = int.Parse(Console.ReadLine());
        DateTime time = DateTime.Parse(Console.ReadLine());

        int sumWats;
        if (time.Hour >= 14 && time.Hour <= 18)
        {
            double nonConsumation = (2 * 100.53 + 2 * 125.90);
            sumWats = (int)(nonConsumation * flats * floors);
        }
        else if (time.Hour >= 19 && time.Hour <= 23)
        {
            double afterConsumation = (7 * 100.53 + 6 * 125.90);
            sumWats = (int)(afterConsumation * flats * floors);
        }
        else if (time.Hour >= 00 && time.Hour <= 8)
        {
            double midnightConsumation = (1 * 100.53 + 8 * 125.90);
            sumWats = (int)(midnightConsumation * flats * floors);
        }
        else
        {

            sumWats = 0;
        }

        Console.WriteLine(sumWats + " Watts");
    }

}