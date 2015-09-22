using System;

class ConsoleGraphics
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("{0}",new string ('*',n*2));
        }
        for (int i = 0; i < n-1; i++)
        {
            Console.WriteLine("{0}{1}{0}",new string('*',n/2+1),new string(' ',n-1));
        }
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("{0}", new string('~', n * 2));
        }
    }
}

