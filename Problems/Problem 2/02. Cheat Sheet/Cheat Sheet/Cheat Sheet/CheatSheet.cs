using System;

class CheatSheet
{
    static void Main()
    {
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());
        long vertical = long.Parse(Console.ReadLine());
        long horizontal = long.Parse(Console.ReadLine());
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                long value = (vertical + i) * (horizontal + j);
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
        
    }
}

