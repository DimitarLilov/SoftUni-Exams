using System;

class SumElements
{
    static void Main()
    {
        string[] inputtext = Console.ReadLine().Split();
        decimal sum = 0;
        decimal maxValue = decimal.MinValue;
        for (int i = 0; i < inputtext.Length; i++)
        {
            decimal element = decimal.Parse(inputtext[i]);
            sum += element;
            
            if (element > maxValue)
            {
                maxValue = element;
            }
        }
        if (sum == 2 * maxValue)
        {
            Console.WriteLine("Yes, sum="+maxValue);
        }
        else
        {
            decimal diff = Math.Abs(sum - 2 * maxValue);
            Console.WriteLine("No, diff={0}",diff);
        }
    }
}

