using System;

class Triangle
{
    static void Main()
    {
        int aX = int.Parse(Console.ReadLine());
        int aY = int.Parse(Console.ReadLine());
        int bX = int.Parse(Console.ReadLine());
        int bY = int.Parse(Console.ReadLine());
        int cX = int.Parse(Console.ReadLine());
        int cY = int.Parse(Console.ReadLine());
        double a = Math.Sqrt((bX - aX) * (bX - aX) + (bY - aY) * (bY - aY));
        double b = Math.Sqrt((cX - bX) * (cX - bX) + (cY - bY) * (cY - bY));
        double c = Math.Sqrt((aX - cX) * (aX - cX) + (aY - cY) * (aY - cY));
        double perimeter = (a + b + c) / 2;
        double area = Math.Sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c));
        if (a + b > c && b + c > a && a + c > b)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("{0:F2}", area);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:F2}", a);
        }
    }
}

