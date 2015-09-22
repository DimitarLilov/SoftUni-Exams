using System;

class PiggyBank
{
    static void Main()
    {
        int price = int.Parse(Console.ReadLine());
        int partyDay = int.Parse(Console.ReadLine());
        if (partyDay > 8)
        {
            Console.WriteLine("never");
        }
        else
        {
            int day = 30;
            int normalDay = day - partyDay;
            int normalDayMoney = normalDay * 2;
            int partyDayMoney = partyDay * 5;
            int moneyForday = normalDayMoney - partyDayMoney;
            double exactly = (double)price / moneyForday;
            int result = (int)Math.Ceiling(exactly);
            int year = result / 12;
            int months = result % 12;

            Console.WriteLine("{0} years, {1} months", year,months);
        }
    }
}


