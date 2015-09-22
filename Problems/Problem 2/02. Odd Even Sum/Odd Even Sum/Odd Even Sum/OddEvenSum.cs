using System;

class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sumodd = 0;
        int sumeven = 0;
        bool odd = true;
        for (int i = 0; i < 2*n; i++)
        {
            int element = int.Parse(Console.ReadLine());
            if (odd)
            {
                sumodd += element;
            }
            else
            {
                sumeven += element;
            }
            odd = !odd;
        }
        if (sumodd == sumeven)
        {
            Console.WriteLine("Yes, sum={0}", sumodd);
        }
        else
        {
            double diff = Math.Abs(sumodd - sumeven);
            Console.WriteLine("No, diff={0}",diff);
        }
    }
}

