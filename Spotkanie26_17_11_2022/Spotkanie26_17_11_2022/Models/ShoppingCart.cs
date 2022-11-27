using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotkanie26_17_11_2022.Models
{
    internal class ShoppingCart
    {
        public List<Product> Products { get; set; } = new  List<Product>();
        public List<ShoppingCart> shoppingCarts { get; set; } = new List<ShoppingCart>();

        public decimal Shopping()
        {
            var run = true;
            decimal sum = 0m;
            while (run)
            {
                int i = 0;
                foreach (var product in Products)
                {
                    Console.WriteLine($"{i} - Name {product.Name} - {product.Price}");
                    i++;
                }
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("l - live  inex == add Product");
                Console.WriteLine($"sum = {sum}");
                Console.WriteLine("----------------------------------------");
                string inp = Console.ReadLine().ToLower();
                try
                {
                    if (inp == "l")
                    {
                        break;
                    }
                    sum += Products[int.Parse(inp)].Price;
                    Console.Clear();
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
            return sum;
        }

        public decimal GetPrice()
        {
            return Products.Sum(x => x.Price);
        }

        public void Clear()
        {
            Products.Clear();
        }
    }
}
