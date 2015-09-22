using System;

class Pairs
{
    static void Main()
    {
        string[] inputString = Console.ReadLine().Split();
        int firstElement = int.Parse(inputString[0]);
        int nextElement = int.Parse(inputString[1]);
        int prev = firstElement + nextElement;

        int maxdiff = 0;
        for (int i = 2; i < inputString.Length - 1; i+=2)
        {
           firstElement =int.Parse(inputString[i]);
           nextElement =  int.Parse(inputString[i + 1]);
           int lastValue = firstElement + nextElement;
           int diff = Math.Abs(lastValue - prev);
           maxdiff = Math.Max(diff, maxdiff);
           prev = lastValue;
        }
        if (maxdiff ==0)
        {
            Console.WriteLine("Yes, value={0}",prev);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}",maxdiff);
        }
    }
}

