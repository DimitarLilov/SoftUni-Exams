using System;

class Tables
{
    static void Main()
    {
        long bundle1 = long.Parse(Console.ReadLine());
        long bundle2 = long.Parse(Console.ReadLine());
        long bundle3 = long.Parse(Console.ReadLine());
        long bundle4 = long.Parse(Console.ReadLine());
        long tops = long.Parse(Console.ReadLine());
        long tables = long.Parse(Console.ReadLine());
        long legs = bundle1 + (bundle2 * 2) + (bundle3 * 3) + (bundle4 * 4);
        long tablesMade = Math.Min((legs / 4), tops);

        if (tablesMade > tables)
        {
            long topLeft = tops - tables;
            long legsLeft = legs - tables * 4;
            Console.WriteLine("more: {0}", tablesMade - tables);
            Console.WriteLine("tops left: {0}, legs left: {1}",topLeft ,legsLeft);
        }
        else if (tablesMade < tables)
        {
            long topsNeedd = tables >= tops ? tables - tops : 0;
            long lagesNeedd = tables * 4 >= legs ? tables * 4 - legs : 0;
            Console.WriteLine("less: {0}", tablesMade - tables);
            Console.WriteLine("tops needed: {0}, legs needed: {1}", topsNeedd, lagesNeedd);
        }
        else 
        {
            Console.WriteLine("Just enough tables made: {0}", tablesMade);
        }
    }
}

