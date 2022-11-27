using ShootingRange.Shop.Guns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShootingRange.Shop;

//Zadanie: implementacja aplikacji do obsługi strzelnicy
//automatyzujemy zamówienia poszczególnych strzelań
//strzelnica ma co najmniej 5 rodzajów broni
//każda broń ma koszt 1 strzału
//pracownik strzelnicy chce wprowadzać do aplikacji ile strzałów klient chce oddać z jakiej broni
//i wygenerować zestawienie kosztów
//tzn:
//koszty wszystkich strzałow
//doliczony vat
//i kwota do zapłacenia
//zestawienie oczywiście na ekranie
//w konsoli
//czekam na propozycje rozwiązań

namespace ShootingRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop.Shop shop = new Shop.Shop();
            //-----------------------------------------------------------------------
            var gun1 = new Gun("A", 200, 1.25);
            var gun2 = new Gun("B", 300, 2.25);
            var gun3 = new Gun("C", 400, 3.25);
            var gun4 = new Gun("D", 500, 4.25);
            var gun5 = new Gun("E", 600, 5.25);
            shop.GunList.Add(gun1);
            shop.GunList.Add(gun2);
            shop.GunList.Add(gun3);
            shop.GunList.Add(gun4);
            shop.GunList.Add(gun5);
            //-----------------------------------------------------------------------
            var run = true;
            while (run)
            {
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("\t\t\t\t USER INTERFACE");
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("a - Infofmations Magazine l - live o - AddOrder oo - OrderInformation");
                Console.WriteLine("r - DeleteOrderByID");
                Console.WriteLine("-----------------------------------------------------------------------");
                var inp = Console.ReadLine().ToLower().Trim();
                switch (inp)
                {
                    case "l":
                        run = false;
                        break;
                    case "a":
                        Console.Clear();
                        shop.Infofmations();
                        break;
                    case "o":
                        Console.Clear();
                        shop.AddOrder();
                        break;
                    case "oo":
                        Console.Clear();
                        shop.OrderInformation();
                        break;
                    case "r":
                        Console.Clear();
                        shop.DeleteOrder();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Such an operation does not exist");
                    break;
                }




            }
            Console.WriteLine("Thank you for your hard work !!!");
            Console.WriteLine("See you ;)");
            Console.ReadKey();
        }
    }
}
