using System;

class CompoundInterest
{
    static void Main()
    {
        double price = double.Parse(Console.ReadLine());
        int yeares = int.Parse(Console.ReadLine());
        double iBank = double.Parse(Console.ReadLine());
        double iFriends = double.Parse(Console.ReadLine());
        double bankPow = (1 + iBank);
        double bank = price * Math.Pow(bankPow, yeares);
        double friend = price * (1 + iFriends);
        if (bank < friend)
        {
            Console.WriteLine("{0:F2} Bank" ,bank);  
        }
        else if (bank > friend)
        {
            Console.WriteLine("{0:F2} Friend" ,friend);
        }
    }
}

