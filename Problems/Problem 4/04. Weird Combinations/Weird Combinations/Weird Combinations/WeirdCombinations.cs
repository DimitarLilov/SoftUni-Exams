using System;

class WeirdCombinations
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] letters = input.ToCharArray();
        int n = int.Parse(Console.ReadLine());
        bool found = false;
        int counter = 0;

        foreach (char c in letters)
        {
            foreach (char c1 in letters)
            {
                foreach (char c2 in letters)
                {
                    foreach (char c3 in letters)
                    {
                        foreach (char c4 in letters)
                        {
                            if (counter == n)
                            {
                                string result = c + "" + c1 + "" + c2 + "" + "" + c3 + "" + "" + c4;
                                Console.WriteLine(result);
                                found = true;
                            }
                            counter++;
                        }
                    }
                }
            }
        }
        if (!found)
        {
            Console.WriteLine("No"); 
        }

    }
}

