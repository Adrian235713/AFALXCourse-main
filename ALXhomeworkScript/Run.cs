using ALXhomeworkScript.Clas;
using ALXhomeworkScript.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXhomeworkScript
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Zad 1");
            Console.WriteLine($"-----------------------------------------------");

            Person peron = new Person("Ala", "Alowata",123, 182.32, 86070307566);
            peron.PersonInformation();
            peron.DayInformation(5, 11, 2022);

            Console.WriteLine("Zad 2");
            Console.WriteLine($"-----------------------------------------------");

            double a = 3;
            double b = 6;
            double c = 15;
            double equation = (Math.Pow(a, b) / 2) % c;
            Console.WriteLine($"Solution = {equation}");
            equation += 5;
            Console.WriteLine($"equation + 5 > a = {equation > 5}");
            Console.WriteLine($"-----------------------------------------------");
            DeMorgana.deMorgana(true, false);
            DeMorgana.deMorgana(false, true);
            DeMorgana.deMorgana(true, true);
            DeMorgana.deMorgana(false, false);
            DeMorgana.deMorganaTest(10);

            Console.WriteLine("Zad 3");
            Console.WriteLine($"-----------------------------------------------");

            Store store = new Store();

            store.AddProduct(1,3.58,5,10,2);
            store.AddProduct(2, 9.61, 5, 25, 5);
            store.AddProduct(3, 8.58, 8, 18, 3);
            store.AddProduct(4, 10.25, 8, 36, 6);
            store.AddProduct(4, 6.17, 23, 4, 1);

            store.StockStatus();

            Console.WriteLine($"-----------------------------------------------");
            store.LiczbyPodzielne(100);

            Console.ReadKey();  
        }
    }
}
