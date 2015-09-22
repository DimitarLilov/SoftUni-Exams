using System;

class AccountInformation
{
    static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        int clientId = int.Parse(Console.ReadLine());
        decimal balance = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Hello, {0} {1}", firstName, lastName);
        Console.WriteLine("Client id: {0}", clientId);
        Console.WriteLine("Total balance: {0:F2}", balance);
        if (balance >= 0)
        {
            Console.WriteLine("Active: yes");

        }
        else if (balance < 0)
        {
            Console.WriteLine("Active: no");
        }
    }
}

