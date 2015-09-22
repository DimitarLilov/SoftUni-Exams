using System;

class Disk
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());
        int diskCenterRow = n / 2, diskCenterCol = n / 2;

        for (int currentRow = 0; currentRow < n; currentRow++)
        {
            for (int currentCol = 0; currentCol < n; currentCol++)
            {
                int deltaX = currentCol - diskCenterCol,
                    deltaY = currentRow - diskCenterRow;
                double distanceToCenter = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
                bool isWithinDisk = distanceToCenter <= r;
                if (isWithinDisk)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
        }

    }
}

