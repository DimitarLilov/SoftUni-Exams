using System;

class ProgrammerDNA
{
    static void Main()
    {
        int totalLength = int.Parse(Console.ReadLine());
        char printChar = char.Parse(Console.ReadLine());
    
        char spaceChar = '.';

        int blockSize = 7;
        int mindPoint = blockSize / 2;
        int diff = 0;
        int diffCunter = 0;
        for (int counter = 0; counter < totalLength; counter++)
        {
            for (int i = 0; i < blockSize; i++)
            {
                if (i >= mindPoint - diff && i <= mindPoint + diff)
                {
                    Console.Write(printChar);
                    if (printChar == 'G')
                    {
                        printChar = 'A';
                    }
                    else
                    {
                        printChar++;
                    }
                }
                else
                {
                    Console.Write(spaceChar);
                }
            }
            if (diffCunter >= mindPoint)
            {
                diff--;
            }
            else
            {
                diff++;
            }
            diffCunter++;
            if (diffCunter == blockSize)
            {
                diffCunter = 0;
                diff++;
            }
            Console.WriteLine();
        }


    }
}

