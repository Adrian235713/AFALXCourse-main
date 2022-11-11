using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXhomeworkPodrecznik2
{
    internal class Exercise1
    {
        private string[] Products = { "A", "B", "C", "D" };
        private double[] Price = {2,4,6,8};

        public void exercise1()
        {
            while (true)
            {
                Console.Write("L - live Products | ");
                foreach (string el in Products)
                {
                    Console.Write($"{el} ");
                }
                Console.WriteLine();
                Console.WriteLine("Choose a product ?");
                string inp = Console.ReadLine().ToUpper();
                if (Products.Contains(inp))
                { 
                    Console.WriteLine($"Price = {Price[Array.IndexOf(Products,inp)]}");
                }
                else if (inp == "L")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("There is no such product");
                }

            }
        }





    }
}
