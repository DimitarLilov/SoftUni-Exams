﻿using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        BigInteger t1 = BigInteger.Parse(Console.ReadLine());
        BigInteger t2 = BigInteger.Parse(Console.ReadLine());
        BigInteger t3 = BigInteger.Parse(Console.ReadLine());
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger result = 0;
        if (n ==1)
        {
           result =t1;
        }
        else if (n == 2)
        {
            result = t2;
        }
        else if (n ==3)
        {
            result = t3;

        }
        for (int i = 3; i < n; i++)
        {

            BigInteger tn = t1 + t2 + t3;
            t1 = t2;
            t2 = t3;
            t3 = tn;
            result = tn;
        }
        Console.WriteLine(result);
    }
}

