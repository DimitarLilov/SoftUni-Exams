using System;

class BookProblem
{
    static void Main()
    {
        int bookPages = int.Parse(Console.ReadLine());
        int campingDays = int.Parse(Console.ReadLine());
        int readsPages = int.Parse(Console.ReadLine());
        if (campingDays == 30 || readsPages == 0)
        {
            Console.WriteLine("never");
            return;
        }
        int year = 12;
        int day = 30;
        int normalDay = Math.Abs(day - campingDays);
        int readsNormalDay = normalDay * readsPages;
        int monthsRead = (int) Math.Ceiling((double) bookPages / readsNormalDay);
        int yesrs = monthsRead / year;
        int months = monthsRead % year;
        {
            Console.WriteLine("{0} years {1} months", yesrs, months);
        }

    }
}

