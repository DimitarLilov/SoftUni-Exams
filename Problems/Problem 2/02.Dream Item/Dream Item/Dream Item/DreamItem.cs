using System;

class DreamItem
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split('\\');
        string month = input[0];
        decimal moneyPerHour = decimal.Parse(input[1]);
        decimal hoursPerDay = decimal.Parse(input[2]);
        decimal priceOfItem = decimal.Parse(input[3]);
        int dayinMonth = 0;
        switch (month)
        {
            case "Jan" :
                dayinMonth += 31;
                break;
            case "Feb":
                dayinMonth += 28;
                break;
            case "March":
                dayinMonth += 31;
                break;
            case "Apr" :
                dayinMonth += 30;
                break;
            case "May":
                dayinMonth += 31;
                break;
            case "June" :
                dayinMonth += 30;
                break;
            case "July" :
                dayinMonth += 31;
                break;
            case "Aug" :
                dayinMonth += 31;
                break;
            case "Sept":
                dayinMonth += 30;
                break;
            case "Oct":
                dayinMonth += 31;
                break;
            case "Nov":
                dayinMonth += 30;
                break;
            case "Dec":
                dayinMonth += 31;
                break;
 
        }
        int workDay = dayinMonth - 10;
        decimal levaMonth = (decimal)workDay * moneyPerHour * hoursPerDay;
        //Console.WriteLine(levaMonth);
        if (levaMonth > 700)
        {
            levaMonth += levaMonth * 0.1M;
        }
        
        if (levaMonth - priceOfItem >= 0)
        {
            Console.WriteLine("Money left = {0:f2} leva.", levaMonth - priceOfItem);
        }
        else
        {
            Console.WriteLine("Not enough money. {0:f2} leva needed.", priceOfItem - levaMonth);
        }

    }
}

