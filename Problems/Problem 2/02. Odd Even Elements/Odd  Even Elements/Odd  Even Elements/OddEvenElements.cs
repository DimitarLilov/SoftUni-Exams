using System;

class OddEvenElements
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture =
    System.Globalization.CultureInfo.InvariantCulture;

        decimal oddMin = decimal.MaxValue;
        decimal oddMax = decimal.MinValue;
        decimal oddSum = 0;
        decimal evenMin = decimal.MaxValue;
        decimal evenMax = decimal.MinValue;
        decimal evenSum = 0;

        string input = Console.ReadLine();
        string[] inputNumber = input.Split(' ');

        if (input == "")
        {
            inputNumber = new string[0]; 
        }
        bool odd = true;

        for (int i = 0; i < inputNumber.Length; i++)
        {
            decimal element = decimal.Parse(inputNumber[i]);
            if (odd)
            {
                oddSum += element;
                oddMin = Math.Min(oddMin, element);
                oddMax = Math.Max(oddMax, element);
            }
            else
            {
                evenSum += element;
                evenMin = Math.Min(evenMin, element);
                evenMax = Math.Max(evenMax, element);
            }
            odd = !odd;
        }

        if (inputNumber.Length == 0)
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
        }
        else if (inputNumber.Length == 1)
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No", (double)oddSum, (double)oddMin, (double)oddMax);
        }
        else
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", (double)oddSum, (double)oddMin, (double)oddMax, (double)evenSum, (double)evenMin, (double)evenMax);
        }
    }
}

