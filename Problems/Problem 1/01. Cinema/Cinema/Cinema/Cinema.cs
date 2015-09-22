using System;

class Cinema
{
    static void Main()
    {
        string projection = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());
        if (projection == "Premiere")
        {
            Console.WriteLine("{0:f2} leva", rows * columns * 12.00);
        }
        else if (projection == "Normal")
        {
            Console.WriteLine("{0:f2} leva", rows * columns * 7.50);
        }
        else if (projection == "Discount")
        {
            Console.WriteLine("{0:f2} leva", rows * columns * 5.00);
        }
    }
}

