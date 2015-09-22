using System;

class BabaTincheAirlines
{
    static void Main()
    {
        string[] firstClass = Console.ReadLine().Split();
        string[] businessClass = Console.ReadLine().Split();
        string[] economyClass = Console.ReadLine().Split();
        double priceFirstClass = 7000;
        double priceBusinessClass = 3500;
        double priceEconomyClass = 1000;
        double purchasemeal = 0.005;
        int totalPassagerFirstClas = 12;
        int totalPassagerBusinessClas = 28;
        int totalPassagerEconomyClass = 50;

        double sumFirstClass = (double.Parse(firstClass[0]) - double.Parse( firstClass[1])) * priceFirstClass;
        sumFirstClass += (double.Parse(firstClass[1])) *  (double)priceFirstClass * 0.3;
        sumFirstClass += (double.Parse(firstClass[2])) * (purchasemeal * priceFirstClass);

        double sumBusinessClass = (double.Parse(businessClass[0]) - double.Parse(businessClass[1])) * priceBusinessClass;
        sumBusinessClass += (double.Parse(businessClass[1])) * (double)priceBusinessClass * 0.3;
        sumBusinessClass += (double.Parse(businessClass[2])) * (purchasemeal * priceBusinessClass);

        double sumEconomyClass = (double.Parse(economyClass[0]) - double.Parse(economyClass[1])) * priceEconomyClass;
        sumEconomyClass += (double.Parse(economyClass[1])) * (double)priceEconomyClass * 0.3;
        sumEconomyClass += (double.Parse(economyClass[2])) * (purchasemeal * priceEconomyClass);


        double allSum = sumFirstClass + sumBusinessClass + sumEconomyClass;
        int maxIncome = (int)(totalPassagerFirstClas * priceFirstClass + totalPassagerFirstClas * (purchasemeal * priceFirstClass)) + (int)(totalPassagerBusinessClas * priceBusinessClass + totalPassagerBusinessClas * (purchasemeal * priceBusinessClass)) + (int)(totalPassagerEconomyClass * priceEconomyClass + totalPassagerEconomyClass * (purchasemeal * priceEconomyClass));

        Console.WriteLine("{0}",(int)allSum);
        Console.WriteLine("{0}",maxIncome - (int)allSum);

    }
}

