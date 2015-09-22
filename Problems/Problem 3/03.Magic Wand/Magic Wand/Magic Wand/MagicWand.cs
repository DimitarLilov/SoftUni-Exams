using System;

class MagicWand
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}*{0}", new string ('.' , n+ (n/2) +1));
        int indots = 1;
        for (int i = 1; i <= (n/2)+1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', (n+ (n/2) +1) - i), new string('.', indots));
            indots += 2;
        }
        Console.WriteLine("{0}{1}{0}", new string ('*',n), new string ('.', n+2));
        int dots = (n *3)-2;
        for (int i = 1; i <= n/2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",new string ('.',i), new string('.',dots) );
            dots -= 2;
        }

        int dot = 0;
        int outdots = (n / 2) - 1;
        for (int i = 0; i < (n/2)-1; i++)
        {
            Console.WriteLine("{0}*{1}*{2}*{3}*{2}*{1}*{0}", new string ('.',outdots),new string ('.', n/2),new string('.',dot), new string ('.',n));
            outdots--;
            dot++;
        }
        Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string ('.',n/2), new string ('.', (n/2)-1), new string ('.',n));
        Console.WriteLine("{0}*{1}*{2}*{1}*{0}", new string('*', n / 2), new string('.', n / 2), new string('.', n));
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}*{0}*{0}", new string ('.',n));
        }
        Console.WriteLine("{0}*{1}*{0}", new string('.', n), new string ('*',n));
    }
}

