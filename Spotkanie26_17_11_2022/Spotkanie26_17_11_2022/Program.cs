using Spotkanie26_17_11_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotkanie26_17_11_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shopingCard = new ShoppingCart();
            shopingCard.Products.Add(new Product { Name = "Mleko", Price = 50.00m });
            shopingCard.Products.Add(new Product { Name = "A", Price = 10.00m });
            shopingCard.Products.Add(new Product { Name = "B", Price = 30.00m });
            shopingCard.Products.Add(new Product { Name = "C", Price = 60.00m });

            //Console.WriteLine(shopingCard.GetPrice());


            decimal z = shopingCard.Shopping();
            Console.WriteLine(z);


            Console.ReadKey();
        }
    }
}
