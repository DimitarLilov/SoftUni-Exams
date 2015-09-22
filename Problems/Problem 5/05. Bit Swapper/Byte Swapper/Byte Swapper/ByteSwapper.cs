using System;

class ByteSwapper
{
    static void Main()
    {
        uint[] numbers = new uint[4];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = uint.Parse(Console.ReadLine());
        }
        while (true)
        {
            string[] from = Console.ReadLine().Split();
            if (from[0] == "End")
            {
                break;
            }
            string[] to = Console.ReadLine().Split();

            int firstNumber = int.Parse(from[0]);
            int secondNumber = int.Parse(to[0]);
            int firstGrup = int.Parse(from[1]) * 4;
            int secondGrup = int.Parse(to[1]) * 4;

            uint fromMask = 15u << firstGrup;
            uint toMask = 15u << secondGrup;
            uint fromByte = (numbers[firstNumber] & fromMask) >> firstGrup;
            uint toByte = (numbers[secondNumber] & toMask) >> secondGrup;

            numbers[firstNumber] &= ~fromMask;
            numbers[secondNumber] &= ~toMask;

            numbers[firstNumber] |= toByte << firstGrup;
            numbers[secondNumber] |= fromByte << secondGrup;
        }
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
