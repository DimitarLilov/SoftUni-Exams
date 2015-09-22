using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
        int indot = n;
        int outdot = n-1;
        for (int i = 0; i < (n/2) -1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.',outdot), new string ('.',indot));
            indot += 2;
            outdot -= 1;
        }
        int asterix = (n /2) + 1;
        int dots = 3*n;
        Console.WriteLine("{0}{1}{0}", new string('*', asterix), new string('.', dots - 2*asterix));
        for (int i = 0; i < (n /2) -2; i++)
        {
            Console.WriteLine("*{0}*", new string ('.', dots - 2));
        }
        Console.WriteLine(new string ('*',dots));
        for (int i = 0; i < (n/2)-2; i++)
        {
            Console.WriteLine("{0}*{1}*{2}*{1}*{0}", new string ('.', n/2), new string ('.', (n/2)-1), new string ('.', n -2));
        }
        Console.WriteLine("{0}{1}{2}{1}{0}", new string ('.',n/2), new string ('*',(n/2)+1) , new string ('.', n -2));
    }
}

