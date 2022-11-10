using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXhomeworkScript.Shop
{
    internal class Store
    {
        List<Product> products = new List<Product>();

        public void StoreService()
        {

        }
        //public int Id;
        //public double NetPrice;
        //public double VAT;
        //public int NumberOfPiecesInTheBox;
        //public int NumberInStock;
        public void AddProduct(int ID, double NetPrice, double VAT, int NumberOfPiecesInTheBox, int NumberInStock)
        {
            Product product = new Product(ID, NetPrice, VAT, NumberOfPiecesInTheBox, NumberInStock);
            products.Add(product);
        }

        public void AddProduct()
        {
            Console.WriteLine("Id");
            int ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("NetPrice");
            double NetPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("VAT");
            double VAT = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("NumberOfPiecesInTheBox");
            int NumberOfPiecesInTheBox = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("NumberInStock");
            int NumberInStock = Convert.ToInt32(Console.ReadLine());

            Product product = new Product(ID, NetPrice, VAT, NumberOfPiecesInTheBox, NumberInStock);
            products.Add(product);
        }

        public void StockStatus()
        {
            Console.WriteLine($"\tStockStatus");
            Console.WriteLine($"-----------------------------------------------");
            foreach (Product product in products)
            {
                product.ProductInformation();
            }
            Console.WriteLine($"-----------------------------------------------");
        }
        public void LiczbyPodzielne(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    Console.WriteLine($"{i} dzieli sie przez {j}");
                }
            }
        }


    }
}
