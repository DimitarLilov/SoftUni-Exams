using System;
using System.Collections.Generic;

class ArrayMatcher
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split('\\');
        char[] rightArray = input[0].ToCharArray();
        char[] leftArray = input[1].ToCharArray();
        string command = input[2];
        List<char> newArray = new List<char>();
        if (command == "join")
        {
            for (int i = 0; i < rightArray.Length; i++)
            {
                char right = rightArray[i];
                for (int j = 0; j < leftArray.Length; j++)
                {
                    char left = leftArray[j];
                    if (right == left)
                    {
                        newArray.Add(right);

                    }

                }

            }

        }
        if (command == "right exclude")
        {
            for (int i = 0; i < rightArray.Length; i++)
            {
                bool constrein = false;
                char right = rightArray[i];
                for (int j = 0; j < leftArray.Length; j++)
                {
                    char left = leftArray[j];
                    if (right == left)
                    {
                        constrein = true;

                    }
                }
                if (!constrein)
                {
                    newArray.Add(right);
                }
            }

        }
        if (command == "left exclude")
        {
            for (int i = 0; i < leftArray.Length; i++)
            {
                bool Chek = false;
                char left = leftArray[i];
                for (int j = 0; j < rightArray.Length; j++)
                {
                    
                    char right = rightArray[j];
                    if (left == right)
                    {
                        Chek = true;
                    }

                }
                if (!Chek)
                {
                    newArray.Add(left);
                }

            }

        }
        newArray.Sort();
        foreach (var item in newArray)
        {
            Console.Write(item);
            
        }
        Console.WriteLine();
    }
}

