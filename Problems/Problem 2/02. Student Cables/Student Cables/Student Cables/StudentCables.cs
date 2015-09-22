using System;

class StudentCables
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int totalLegth = 0;
        int joins = 0;

        for (int i = 0; i < n; i++)
        {
            int length = int.Parse(Console.ReadLine());
            string measures = Console.ReadLine();
            if (measures == "meters")
            {
                length = length * 100;
            }
            if (length >= 20)
            {
                totalLegth += length;
                joins++;
            }
        }
        totalLegth = totalLegth - 3 * (joins - 1);
        int cabelconect = totalLegth / 504;
        int remainder = totalLegth % 504;
        Console.WriteLine(cabelconect);
        Console.WriteLine(remainder);
    }
}

