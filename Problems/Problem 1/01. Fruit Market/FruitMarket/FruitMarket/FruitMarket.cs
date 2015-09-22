using System;
using System.Collections.Generic;


class FruitMarket
{
    static void Main()
    {
        string day = Console.ReadLine();
        double quantity1 = double.Parse(Console.ReadLine());
        string produkt1 = Console.ReadLine();
        double quantity2 = double.Parse(Console.ReadLine());
        string produkt2 = Console.ReadLine();
        double quantity3 = double.Parse(Console.ReadLine());
        string produkt3 = Console.ReadLine();
        Dictionary<string, double> produkt = new Dictionary<string, double>();

        produkt.Add("banana", 1.80);
        produkt.Add("cucumber", 2.75);
        produkt.Add("tomato", 3.20);
        produkt.Add("orange", 1.60);
        produkt.Add("apple", 0.86);

        switch (day)
        {
            case "Friday":
                {
                    produkt["banana"] -= 10.0 / 100 * produkt["banana"];
                    produkt["cucumber"] -= 10.0 / 100 * produkt["cucumber"];
                    produkt["tomato"] -= 10.0 / 100 * produkt["tomato"];
                    produkt["orange"] -= 10.0 / 100 * produkt["orange"];
                    produkt["apple"] -= 10.0 / 100 * produkt["apple"];
                    break;
                }
            case "Sunday":
                {
                    produkt["banana"] -= 5.0 / 100 * produkt["banana"];
                    produkt["cucumber"] -= 5.0 / 100 * produkt["cucumber"];
                    produkt["tomato"] -= 5.0 / 100 * produkt["tomato"];
                    produkt["orange"] -= 5.0 / 100 * produkt["orange"];
                    produkt["apple"] -= 5.0 / 100 * produkt["apple"];
                    break;
                }
            case "Tuesday":
                {
                    produkt["banana"] -= 20.0 / 100 * produkt["banana"];
                    produkt["orange"] -= 20.0 / 100 * produkt["orange"];
                    produkt["apple"] -= 20.0 / 100 * produkt["apple"];
                    break;
                }
            case "Wednesday":
                {
                    produkt["cucumber"] -= 10.0 / 100 * produkt["cucumber"];
                    produkt["tomato"] -= 10.0 / 100 * produkt["tomato"];
                    break;
                }
            case "Thursday":
                {
                    produkt["banana"] -= 30.0 / 100 * produkt["banana"];
                    break;
                }
        }
        double sum = quantity1 * produkt[produkt1] + quantity2 * produkt[produkt2] + quantity3 * produkt[produkt3];
        Console.WriteLine("{0:F2}", sum);
    }


}

