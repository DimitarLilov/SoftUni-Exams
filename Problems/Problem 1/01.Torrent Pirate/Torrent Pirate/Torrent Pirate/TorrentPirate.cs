using System;

class TorrentPirate
{
    static void Main()
    {
        int megabyte = int.Parse(Console.ReadLine());
        int cost = int.Parse(Console.ReadLine());
        int moneyPerHour = int.Parse(Console.ReadLine());

        double downlodTime = (double)megabyte / 2 / 60 / 60;
        double priceForDown = downlodTime * moneyPerHour;
        double numberMoviesDown =(double) megabyte / 1500;
        double priceCinema = numberMoviesDown * cost;
        if (priceCinema < priceForDown)
        {
            Console.WriteLine("cinema -> {0:f2}lv", priceCinema);
        }
        else
        {
            Console.WriteLine("mall -> {0:f2}lv", priceForDown);
        }




    }
}
