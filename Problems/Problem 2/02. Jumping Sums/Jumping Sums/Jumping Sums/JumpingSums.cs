using System;

class JumpingSums
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int jump = int.Parse(Console.ReadLine());
        int[] numbers = new int[input.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }
        int maxSum = Int32.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            int velue = numbers[i];
            int currenIndex = i;
            int nexIndex = (currenIndex + velue) % numbers.Length;
            int sum = 0;
            for (int j = 0; j <= jump; j++)
            {
                sum += velue;
                velue = numbers[nexIndex];
                currenIndex = nexIndex;
                nexIndex = (currenIndex + velue) % numbers.Length;
            }
            if (sum > maxSum)
            {
                maxSum = sum;
            }
        }
        Console.WriteLine("max sum = {0}", maxSum);
    }
}

