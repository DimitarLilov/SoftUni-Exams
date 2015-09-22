using System;

class BitsCrossroads
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int[] matrix = new int[size];
        int numberOfCrossrads = 0;

        string command = Console.ReadLine();

        while (command != "end")
        {
            int row = int.Parse(command.Split()[0]);
            int col = int.Parse(command.Split()[1]);

            numberOfCrossrads++;

            matrix[row] |= 1 << col;
            int currentRow = row - 1;
            int currentCol = col + 1;

            while (0 <= currentRow && currentRow < size && 0 <= currentCol && currentCol < size)
            {
                if (((matrix[currentRow] >> currentCol)& 1) == 1)
                {
                    numberOfCrossrads++;
                }
                matrix[currentRow] |= 1 << currentCol;

                currentRow--;
                currentCol++;
            }
            currentRow = row + 1;
            currentCol = col - 1;

            while (0 <= currentRow && currentRow < size && 0 <= currentCol && currentCol < size)
            {
                if (((matrix[currentRow] >> currentCol)& 1) == 1)
                {
                    numberOfCrossrads++;
                }
                matrix[currentRow] |= 1 << currentCol;
                currentRow++;
                currentCol--;
            }
            currentRow = row + 1;
            currentCol = col +1;
            while (0 <= currentRow && currentRow < size && 0 < currentCol && currentCol < size)
            {
                if (((matrix[currentRow] >> currentCol) & 1) == 1)
                {
                    numberOfCrossrads++;
                }
                matrix[currentRow] |= 1 << currentCol;
                currentRow++;
                currentCol++;
            }
                currentRow = row - 1;
                currentCol = col - 1;
            
                while (0 <= currentRow && currentRow < size && 0 <= currentCol && currentCol < size)
                {
                    if (((matrix[currentRow] >> currentCol) & 1) == 1)
                    {
                        numberOfCrossrads++;
                    }
                    matrix[currentRow] |= 1 << currentCol;

                    currentRow--;
                    currentCol--;
                }
                command = Console.ReadLine();
            
           
        }
        foreach (var number in matrix)
        {
            Console.WriteLine((uint)number);
        }
        Console.WriteLine(numberOfCrossrads);
    }
}
