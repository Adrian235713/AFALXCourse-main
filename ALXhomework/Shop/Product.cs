using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXhomeworkScript.Shop
{
    internal class Product
    {
        public int Id;
        public double NetPrice;
        public double VAT;
        public int NumberOfPiecesInTheBox;
        public int NumberInStock;

        public Product(int id, double netPrice, double VAT, int numberOfPiecesInTheBox, int numberInStock)
        {
            this.Id = id;
            this.NetPrice = netPrice;
            this.VAT = VAT;
            this.NumberOfPiecesInTheBox = numberOfPiecesInTheBox;
            this.NumberInStock = numberInStock;
        }

        public void ProductInformation()
        {
            Console.WriteLine($"-----------------------------------------------");
            Console.WriteLine($"ID \t {Id}");
            Console.WriteLine($"NetPrice \t {NetPrice}");
            Console.WriteLine($"VAT \t {VAT}");
            Console.WriteLine($"NumberOfPiecesInTheBox \t {NumberOfPiecesInTheBox}");
            Console.WriteLine($"NumberInStock \t {NumberInStock}");
            Console.WriteLine($"The price for the box \t NetPrice {NumberOfPiecesInTheBox*NetPrice} \t VAT {NumberOfPiecesInTheBox * NetPrice + (VAT/100)*(NumberOfPiecesInTheBox * NetPrice)}");
            Console.WriteLine($"Price per item \t NetPrice {NetPrice} \t VAT {NetPrice + (VAT / 100)*NetPrice}");
            Console.WriteLine($"-----------------------------------------------");
        }



    }
}
