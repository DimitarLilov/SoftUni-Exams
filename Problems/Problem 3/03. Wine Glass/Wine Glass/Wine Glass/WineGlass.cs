using System;

class WineGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int asterix = n;

        for (int i = 0; i < n; i++)
        {
            if (i < n / 2)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('.', i), new string('*', asterix - 2));
                asterix -= 2;
            }

            else if (n < 12 && i < n - 1 || n >= 12 && i < n - 2)
            {

                Console.WriteLine("{0}||{0}", new string('.', (n / 2) - 1));
            }
            else
            {
                Console.WriteLine(new string('-', n));

            }
        }
    }
}

