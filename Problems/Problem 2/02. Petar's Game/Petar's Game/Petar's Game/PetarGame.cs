using System;
using System.Numerics;

class PetarGame
{
    static void Main()
    {
        ulong startNumber = ulong.Parse(Console.ReadLine());
        ulong endNumber = ulong.Parse(Console.ReadLine());
        string inputsreing = Console.ReadLine();
        BigInteger  sum = 0;
        for (ulong i = startNumber; i < endNumber; i++)
        {
            if ( i % 5 == 0)
            {
                sum += i;
            }
            else
            {
                sum += i % 5;
            }
        }
        string sumToString = sum.ToString();
        string newString;
        if (sum % 2 == 0)
        {
            newString = sumToString[0].ToString();

        }
        else
        {
            newString = sumToString[sumToString.Length - 1].ToString();
        }
        sumToString = sumToString.Replace(newString, inputsreing);
        Console.WriteLine(sumToString);
    }
}

