using System;

class BitLock
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int[] lockRows = Array.ConvertAll(input, int.Parse);
        string comand = Console.ReadLine();
        while (comand != "end")
        {
            string[] order = comand.Split();
            if (order[0] == "check")
            {
                int col = int.Parse(order[1]);
                int count = 0;
                foreach (var row in lockRows)
                {
                    count += (row >> col) & 1;
                }
                Console.WriteLine(count);
            }
            else
            {
                int row = int.Parse(order[0]);
                string direction = order[1];
                int rotation = int.Parse(order[2]) %12;
                if (direction == "left")
                {
                    for (int i = 0; i < rotation; i++)
                    {
                        int leftMostBit = (lockRows[row] >> 11) & 1;
                        lockRows[row] &= ~(1 << 11);
                        lockRows[row] <<= 1;
                        lockRows[row] |= leftMostBit;
                    }
                }
                else if (direction == "right")
                {
                    for (int i = 0; i < rotation; i++)
                    {
                        int rightMostBit = lockRows[row] & 1;
                        lockRows[row] >>= 1;
                        lockRows[row] |= rightMostBit << 11;    
                    }


                }
            }






            comand = Console.ReadLine();

        }

        foreach (var row in lockRows)
        {
            Console.Write(row + " ");
        }
    }
}

