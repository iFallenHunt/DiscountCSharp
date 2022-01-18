using System;
using System.Globalization;

namespace uri1008
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o preço do produto: ");

            double preco = double.Parse(Console.ReadLine());
            double desconto = 0.0;
                        
            if (preco > 100.00)
            {
                desconto = preco * 0.1;
            }

            Console.WriteLine("O valor do desconto é: ");
            Console.WriteLine(desconto);
        }
    }
}