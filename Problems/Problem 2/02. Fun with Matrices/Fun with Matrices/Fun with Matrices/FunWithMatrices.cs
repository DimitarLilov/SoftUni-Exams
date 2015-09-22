using System;

class FunWithMatrices
{
    static void Main()
    {
        double startNumber = double.Parse(Console.ReadLine());
        double endtNumber = double.Parse(Console.ReadLine());
        double[,] matrix = new double[4, 4];
        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                matrix[row, col] = startNumber;
                startNumber = endtNumber + startNumber;
            }
        }
        string[] comand = Console.ReadLine().Split();
        while (comand[0] != "Game")
        {
            int row = int.Parse(comand[0]);
            int col = int.Parse(comand[1]);
            string order = comand[2];
            double num = double.Parse(comand[3]);

            switch (order)
            {
                case "multiply":
                    matrix[row, col] *= num;
                    break;
                case  "sum":
                    matrix[row, col] += num;
                    break;
                case   "power":
                    matrix[row, col] = Math.Pow(matrix[row, col], num);
                    break;
                
            }

            comand = Console.ReadLine().Split();
        }
        double maxSum = double.MinValue;
        int index = 0;
        string maxType = "ROW";
        for (int row = 0; row < 4; row++)
        {
            double sum = matrix[row, 0] + matrix[row, 1] + matrix[row, 2] + matrix[row, 3];
            if (sum > maxSum)
            {
                maxSum = sum;
                index = row;
            }
        }
        for (int col = 0; col < 4; col++)
        {
            double sum = matrix[0, col] + matrix[1, col] + matrix[2, col] + matrix[3, col];
            if (sum > maxSum)
            {
                maxSum = sum;
                index = col;
                maxType = "COLUMN";
            }
        }
        double leftDiagonal = matrix[0, 0] + matrix[1, 1] + matrix[2, 2] + matrix[3, 3];
        if (leftDiagonal > maxSum)
        {
            maxSum = leftDiagonal;
            maxType = "LEFT-DIAGONAL";
        }
        double rightDiagonal = matrix[3, 0] + matrix[2, 1] + matrix[1, 2] + matrix[0, 3];
        if (rightDiagonal > maxSum)
        {
            maxSum = rightDiagonal;
            maxType = "RIGHT-DIAGONAL";
        }
        if (maxType == "ROW" || maxType == "COLUMN")
        {
             Console.WriteLine("{0}[{1}] = {2:f2}", maxType, index, maxSum);
        }
        else
        {
            Console.WriteLine("{0} = {1:f2}", maxType, maxSum);
        }
    }
}

