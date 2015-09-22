using System;

class HalfSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
           int element = int.Parse(Console.ReadLine());
           sum += element;
        }
        int sum2 = 0;
        for (int i = 0; i < n; i++)
        {
            int element = int.Parse(Console.ReadLine());
            sum2 += element;
        }
        if (sum == sum2)
        {
            Console.WriteLine("Yes, sum={0}", sum);
        }
        else
        {
            int diff = Math.Abs(sum - sum2);
            Console.WriteLine("No, diff={0}",diff);
        }
    }
}

