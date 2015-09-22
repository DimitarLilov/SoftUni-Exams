using System;

class BitPaths
{
    static void Main()
    {
        int[,] board = new int[8, 4];
        int num = int.Parse(Console.ReadLine());
        for (int i = 0; i < num; i++)
        {
            ProcessPath(board, Console.ReadLine());
        }
        int sum = 0;
        for (int i = 0; i < board.GetLength(0); i++)
        {
            var bits = new int[] { board[i, 0], board[i, 1], board[i, 2], board[i, 3] };
            string str = string.Concat(bits);
            sum = sum + Convert.ToInt32(str, 2);
        }
        Console.WriteLine(Convert.ToString(sum, 2));
        Console.WriteLine(sum.ToString("X"));
    }
    private static void ProcessPath(int[,] board, string patch)
    {
        string[] pathElements = patch.Split(new char[] { ',' });
        int num = int.Parse(pathElements[0]);
        board[0, num] = board[0, num] ^ 1;
        for (int i = 1; i < board.GetLength(0); i++)
        {
            num = num + int.Parse(pathElements[i]);
            board[i, num] = board[i, num] ^ 1;
        }
    }
}

