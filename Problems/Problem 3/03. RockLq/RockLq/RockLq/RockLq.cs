using System;

class RockLq
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outDots = n -2;
        int inDots = n + 2;
        Console.WriteLine("{0}{1}{0}", new string ('.',n),new string ('*',n));
        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.',outDots), new string('.',inDots));
            outDots -= 2;
            inDots += 4;
        }
        Console.WriteLine("*{0}*{1}*{0}*",new string ('.',n-2),new string ('.',n));
        int dots = (n - 2) - 2;
        int indot = 1;
        for (int i = 0; i < (n/2)-1; i++)
        {
            Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*",new string ('.',dots),new string ('.',indot), new string ('.',n));
            dots -= 2;
            indot += 2;
        }
        int dot = n;
        for (int i = 0; i < n-1; i++)
        {
           Console.WriteLine("{0}*{1}*{0}",new string ('.',(n-1)-i),new string ('.',dot));
           dot += 2;
        }
        Console.WriteLine(new string('*',n*3));
    }
}

