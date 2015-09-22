using System;

class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int asterix = 1;

        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine("{0}{1}{0}",new string('-',(n/2)-i),new string ('*',asterix) );
            asterix += 2;
        }
        Console.WriteLine("{0}",new string ('*',n));
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("|{0}|",new string('*',n-2));
        }
    }
}

