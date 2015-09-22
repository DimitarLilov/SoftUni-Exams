using System;

class MelonsWatermelons
{
    static void Main()
    {
        int startingDay = int.Parse(Console.ReadLine());
        int specifyting = int.Parse(Console.ReadLine());
        int melons = 0;
        int watermelos = 0;
        for (int i = startingDay; i < specifyting + startingDay; i++)
        {
            switch (i % 7)
            {
                case 1:
                    watermelos += 1;
                    break;
                case 2:
                    melons += 2;
                    break;
                case 3:
                    watermelos += 1;
                    melons += 1;
                    break;
                case 4:
                    watermelos += 2;
                    break;
                case 5:
                    watermelos += 2;
                    melons += 2;
                    break;
                case 6:
                    watermelos += 1;
                    melons += 2;
                    break;
                default:
                    break;
            }
        }
        int deff = Math.Abs(melons - watermelos);
        if (melons > watermelos)
        {
            Console.WriteLine("{0} more melons", deff);
        }
        else if (watermelos > melons)
        {
            Console.WriteLine("{0} more watermelons", deff);
        }
        else
        {
            Console.WriteLine("Equal amount: {0}", melons);
        }
    }
}

