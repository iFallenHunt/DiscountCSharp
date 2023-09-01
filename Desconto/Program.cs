using System;
using System.Globalization;

namespace uri1008
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the price of the product: ");

            double price = double.Parse(Console.ReadLine());
            double discount = 0.0;
                        
            if (price > 100.00)
            {
                discount = price * 0.1;
            }

            Console.WriteLine("The value of the discount is: ");
            Console.WriteLine(discount);
        }
    }
}
