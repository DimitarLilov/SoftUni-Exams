using System;

class SandGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string ('.',i), new string ('*', n -i-i));
        }
        Console.WriteLine("{0}*{0}",new string ('.',n/2));
        int inasterix = 3;
        for (int i = 0; i < n/2-1; i++)
        {
            Console.WriteLine("{0}{1}{0}",new string ('.',(n/2)-1-i),new string('*',inasterix));
            inasterix += 2;
        }
        Console.WriteLine("{0}",new string ('*',n));
    }
}

