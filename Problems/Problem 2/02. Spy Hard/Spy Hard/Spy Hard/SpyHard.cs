using System;
using System.Text;

class SpyHard
{
    static void Main()
    {
        int kay = int.Parse(Console.ReadLine());
        string message = Console.ReadLine().ToUpper();
        int cunterChar = 0;
        int sum = 0;

        for (int i = 0; i < message.Length; i++)
        {
            int symbol = (int)(message[i]);
            if (symbol >= 'A' && symbol <= 'Z')
            {
                symbol -= 64;
                sum += symbol;
            }
            else
            {
                sum += symbol;
            }
            cunterChar++;
            
        }
        StringBuilder numeralSystemConverter = new StringBuilder();

        while (sum > 0)
        {
            numeralSystemConverter.Insert(0, sum % kay);
            sum /= kay;
        }

        Console.WriteLine("{0}{1}{2}",kay , cunterChar , numeralSystemConverter);
        
    }
}

