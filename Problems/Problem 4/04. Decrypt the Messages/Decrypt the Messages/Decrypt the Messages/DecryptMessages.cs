using System;
using System.Collections.Generic;

class DecryptMessages
{
    static void Main()
    {
        string inputString = string.Empty;
        List<string> msge = new List<string>();
        do
        {
            inputString = Console.ReadLine();
        } while (inputString.ToUpper() != "START");
        inputString = Console.ReadLine();
        while (inputString.ToUpper() != "END")
        {
            if (inputString != "")
            {
                string mesage = "";
                for (int i = 0; i < inputString.Length; i++)
                {
                    if ((inputString[i] >= 'A' && inputString[i] <= 'Z') || (inputString[i] >= 'a' && inputString[i] <= 'z'))
                    {
                        if ((inputString[i] >= 'A' && inputString[i] <= 'M') || (inputString[i] >= 'a' && inputString[i] <= 'm'))
                        {
                            mesage += (char)(inputString[i] + 13);
                        }
                        else 
                        {
                            mesage += (char)(inputString[i] - 13);
                        }
                    }
                    else
                    {
                        switch (inputString[i])
                        {
                            case '+':
                                mesage += ' ';
                                break;
                            case '%':
                                mesage += ',';
                                break;
                            case '&':
                                mesage += '.';
                                break;
                            case '#':
                                mesage += '?';
                                break;
                            case '$':
                                mesage += '!';
                                break;
                            default:
                                mesage += inputString[i];
                                break;
                        }

                    }
                }
                char[] revarseArray = mesage.ToCharArray();
                Array.Reverse(revarseArray);
                mesage = new string(revarseArray);
                msge.Add(mesage);
            }
            inputString = Console.ReadLine();
        }
        if (msge.Count != 0)
        {
            Console.WriteLine("Total number of messages: {0}", msge.Count); 
            foreach (var msg in msge)
            {
                Console.WriteLine(msg);
            }

        }
        else
        {
            Console.WriteLine("No message received.");
        }
    }
}

