using System;

class Boat
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outdot = 1;
        bool middlePointReached = false;
        for (int i = 0; i < n; i++)
        {
          Console.Write(new string('.', n - outdot));
                Console.Write(new string('*', outdot));
                Console.WriteLine(new string('.', n));
                
                if (outdot >= n)
                {
                    middlePointReached = true;
                }

                if (middlePointReached)
                {
                    outdot -= 2;
                }
                else
                {
                    outdot += 2;
                }
        }
        int dot = 0;
        int boatWidth = n + n;
        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', dot), new string('*', boatWidth));
            boatWidth -= 2;
            dot++;
        }

    }
}

