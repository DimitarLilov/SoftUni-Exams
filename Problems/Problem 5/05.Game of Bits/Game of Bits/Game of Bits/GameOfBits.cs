using System;

class GameOfBits
{
    static void Main()
    {
        uint num = uint.Parse(Console.ReadLine());
        uint newNum = num;
        string comand = Console.ReadLine();
        while (comand != "Game Over!")
        {
            if (comand == "Even")
            {
                num >>= 1;
            }
            newNum = ExtractBits(newNum, num);
            num = newNum;
            comand = Console.ReadLine();
        }
        int count = 0;
        while (newNum > 0 )
        {
            uint bit = newNum & 1;
            if (bit == 1)
            {
                count++;
            }
            newNum >>= 1;
        }
        Console.WriteLine("{0} -> {1}", num , count);
    }
    private static uint ExtractBits(uint newNum, uint num)
    {
        newNum = num & 1;
        num >>= 2;
        int count = 1;
        while (num !=0)
        {
            newNum |= (num & 1) << count;
            num >>= 2;
            count++;
        }
        return newNum;
    }
}

