using System;

class BaiIvanAdventures
{
    static void Main()
    {
        int dayOfWeek = int.Parse(Console.ReadLine());
        decimal availableMoney = decimal.Parse(Console.ReadLine());
        decimal desiredAlcohol = decimal.Parse(Console.ReadLine());
        decimal boughtAlcohol =0;
        switch (dayOfWeek)
        {
            case 0 : boughtAlcohol = availableMoney / 25M;break;
            case 1: boughtAlcohol = availableMoney / 21M; break;
            case 2: boughtAlcohol = availableMoney / 14M; break;
            case 3: boughtAlcohol = availableMoney / 17M; break;
            case 4: boughtAlcohol = availableMoney / 45M; break;
            case 5: boughtAlcohol = availableMoney / 59M; break;
            case 6: boughtAlcohol = availableMoney / 42M; break;
        }
        string status = "" ;
        if (boughtAlcohol > 1.5m)
        {
            status = "very drunk";
        }
        else if (boughtAlcohol >= 1.0m)
        {
            status = "drunk";
        }
        else
        {
            status = "sober";
        }
        if (desiredAlcohol < boughtAlcohol)
        {
            Console.WriteLine("Bai Ivan is {0} and very happy and he shared {1:F2} l. of alcohol with his friends", status,boughtAlcohol - desiredAlcohol);
        }
        else if (desiredAlcohol == boughtAlcohol)
        {
            Console.WriteLine("Bai Ivan is {0} and happy. He is as drunk as he wanted", status);
        }
        else
        {
            Console.WriteLine("Bai Ivan is {0} and quite sad. He wanted to drink another {1:f2} l. of alcohol", status, Math.Abs(boughtAlcohol - desiredAlcohol));
        }
    }
}

