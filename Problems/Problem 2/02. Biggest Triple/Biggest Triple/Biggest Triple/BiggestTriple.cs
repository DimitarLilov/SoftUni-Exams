using System;

class BiggestTriple
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] numbers = input.Split();
        long maxSum = long.MinValue;
        long index = 0;
        long start = 0;
        while (index < numbers.Length)
        {
            long num1 = long.Parse(numbers[index]);
            long num2 = 0;
            if (index + 1 < numbers.Length)
            {
                num2 = long.Parse(numbers[index + 1]);
            }
            long num3 = 0;
            if (index + 2 < numbers.Length)
            {
                num3 = long.Parse(numbers[index + 2]);
            }
            long sum = num1 + num2 + num3;
            if (sum > maxSum)
            {
                maxSum = sum;
                start = index;
            }
            index = index + 3;
        }
        while (maxSum != 0)
        {
            Console.Write(numbers[start]);
            maxSum = maxSum - long.Parse(numbers[start]);
            start++;
            if (maxSum != 0)
            {
                Console.Write(" ");
            }
        }
    }
}

