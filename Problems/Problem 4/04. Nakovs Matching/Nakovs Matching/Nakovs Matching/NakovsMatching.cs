using System;

class NakovsMatching
{
    static void Main()
    {
        string firstString = Console.ReadLine();
        string secondString = Console.ReadLine();
        int max = int.Parse(Console.ReadLine());

        bool found = false;
        for (int firstIndex = 1; firstIndex <= firstString.Length - 1; firstIndex++)
        {
            string leftFirstStr = firstString.Substring(0, firstIndex);
            string rightFirstStr = firstString.Substring(firstIndex);
            int leftFirstWeight = SumChars(leftFirstStr);
            int rightFirstWeight = SumChars(rightFirstStr);

            for (int secondIndex = 1; secondIndex <= secondString.Length - 1; secondIndex++)
            {
                string leftSecondStr = secondString.Substring(0, secondIndex);
                string rightSecondStr = secondString.Substring(secondIndex);
                int leftSecondWeight = SumChars(leftSecondStr);
                int rightSecondWeight = SumChars(rightSecondStr);

                int diff = Math.Abs(leftFirstWeight * rightSecondWeight - rightFirstWeight * leftSecondWeight);
                if (diff <= max)
                {
                    Console.WriteLine(
                        '(' + leftFirstStr + '|' + rightFirstStr + ") matches (" +
                        leftSecondStr + '|' + rightSecondStr + ") by " + diff + " nakovs");
                    found = true;
                }
            }
        }
        if (!found)
        {
            Console.WriteLine("No");
        }

    }
    static int SumChars(string str)
    {
        int sum = 0;
        foreach (char ch in str)
        {
            sum += (int)ch;
        }
        return sum;
    }
}

