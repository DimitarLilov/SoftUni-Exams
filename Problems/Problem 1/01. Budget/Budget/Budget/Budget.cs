using System;

class Budget
{
    static void Main()
    {
        int money = int.Parse(Console.ReadLine());
        int weekdays = int.Parse(Console.ReadLine());
        int hometown = int.Parse(Console.ReadLine());

        int totalExpense = weekdays * (int)((0.03 * money) + 10) + ((22 - weekdays) * 10) + ((4 - hometown) * 2 * 20) +
            150;
		
		if (totalExpense==money)
		{
			Console.WriteLine("Exact Budget.");
		}
		else if (totalExpense<money)
		{
			Console.WriteLine("Yes, leftover {0}.",money-totalExpense);
		}
		else
		{
			Console.WriteLine("No, not enough {0}.", totalExpense-money);
		}

    }
}

