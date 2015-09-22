using System;
class BitBuilder
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        string comand = Console.ReadLine();

        while (comand != "quit")
        {
            int position = int.Parse(comand);
            comand = Console.ReadLine();
            long mask = 0;
            string baynaryMask = new string('1', position);
            if (position != 0)
            {
                mask = Convert.ToInt64(baynaryMask, 2);
            }
            long rightSymbol = number & mask;
            switch (comand)
            {
                case "flip":
                    number ^= 1 << position;
                    break;
                case "remove":
                    number >>= position + 1;
                    number <<= position;
                    number |= rightSymbol;
                    break;
                case "insert":
                    number >>= position;
                    number <<= position + 1;
                    number |= (long)1 << position;
                    number |= rightSymbol;
                    break;
            }

            comand = Console.ReadLine();
        }
        Console.WriteLine(number);
    }
}
