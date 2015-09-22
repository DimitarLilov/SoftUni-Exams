using System;

class Stars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}*{0}",new string ('.',n));
        int intdots = 1;

        for (int i = 0; i < (n/2)-1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",new string ('.',(n-1)-i),new string ('.',intdots));
            intdots += 2;
        }
        Console.WriteLine("{0}{1}{0}", new string('*', n/2+1), new string('.', n - 1));
        int inDots= (2*n +1)-2;
        for (int i = 1; i < (n/2); i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string ('.',i),new string ('.',inDots-2));
            inDots -= 2;

        }
        int outdot=n/2;
        Console.WriteLine("{0}*{1}*{1}*{0}", new string ('.',outdot), new string ('.',outdot-1));
        int dot = 1;
        for (int i = 1; i < (n/2); i++)
        {
            Console.WriteLine("{0}*{1}*{2}*{1}*{0}",new string ('.',outdot-i),new string ('.',outdot-1),new string ('.',dot));
            dot += 2;
        }
        Console.WriteLine("{0}{1}{0}", new string('*', n / 2 + 1), new string('.', n - 1));
    }
}

