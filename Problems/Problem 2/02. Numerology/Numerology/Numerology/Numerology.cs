using System;

class Numerology
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split('.', ' ');

        int day = int.Parse(input[0]);
        int month = int.Parse(input[1]);
        int year = int.Parse(input[2]);
        string username = input[3];

        long result = day * month * year;
        if (month % 2 == 1)
        {
            result *= result;
        }
        for (int i = 0; i < username.Length; i++)
        {
            char cunterChar = username[i];
            if (cunterChar >= '0' && cunterChar <= '9')
            {
                result += cunterChar - '0';
            }
            else if (cunterChar >= 'a' && cunterChar <= 'z')
            {
                result += cunterChar - 'a' + 1;
            }
            else if (cunterChar >= 'A' && cunterChar <= 'Z')
            {
                result += 2 * (cunterChar - 'A' + 1);
            }
        }
        while (result > 13)
        {
            int digitSum = 0;
            while (result > 0)
            {
                digitSum += (int)(result % 10);
                result /= 10;
            }
            result = digitSum;
        }
        Console.WriteLine(result);
    }
}

