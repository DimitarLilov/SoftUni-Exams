using System;

class CurrencyCheck
{
    static void Main()
    {
        double rubles = double.Parse(Console.ReadLine());
        double dollars = double.Parse(Console.ReadLine());
        double euro = double.Parse(Console.ReadLine());
        double twocopies = double.Parse(Console.ReadLine());
        double normalLeva = double.Parse(Console.ReadLine());

        rubles = (rubles / 100) * 3.5;
        dollars *= 1.5;
        euro *= 1.95;
        twocopies /= 2;
        double min = double.MaxValue;
        min = Math.Min(rubles, min);
        min = Math.Min(dollars, min);
        min = Math.Min(euro, min);
        min = Math.Min(twocopies, min);
        min = Math.Min(normalLeva, min);
        Console.WriteLine("{0:f2}",min);


    }
}
