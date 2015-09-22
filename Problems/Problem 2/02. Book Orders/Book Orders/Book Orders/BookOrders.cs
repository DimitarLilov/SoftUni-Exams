using System;
class BookOrders
{
    static void Main()
    {
        int numberOfOrders = int.Parse(Console.ReadLine());
        double totalprice = 0;
        int allBoughtBoks = 0;
        
        for (int i = 0; i < numberOfOrders; i++)
        {

            int pacets = int.Parse(Console.ReadLine());
            int boks = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            int allbooks = pacets * boks;
            allBoughtBoks += allbooks;

            double discount = 0;
            if (pacets >= 10 && pacets < 110)
            {
                discount = (pacets / 10) + 4;
            }
            else if (pacets >= 100)
            {
                discount = 15;
            }
            double priceDiscount = price * (100 - discount) / 100;
            totalprice += priceDiscount * allbooks;
        }
        Console.WriteLine(allBoughtBoks);
        Console.WriteLine("{0:F2}", totalprice);
    }
}

