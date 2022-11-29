using ShootingRange.Shop.Guns;
using System;
using ShootingRange.ShopFolder.OrderFolder;

namespace ShootingRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop.Shop shop = new Shop.Shop();
            //----------------------------------------------------------------------------------------------------------------------------
            var gun1 = new Gun("Aexa", 200, 1.25, false);
            var gun2 = new Gun("Bob", 300, 2.25, false);
            var gun3 = new Gun("Ciry", 400, 3.25, false);
            var gun4 = new Gun("Dylan", 500, 4.25, true);
            var gun5 = new Gun("Elixsir", 600, 5.25, true);
            //----------------------------------------------------------------------------------------------------------------------------
            var ord1 = new Order(gun1.ID, 10, gun1.PrizeForOneShot, "11.11.2020", "Jan","Kowalski", gun1.Automatic);
            var ord2 = new Order(gun1.ID, 2, gun1.PrizeForOneShot, "11.11.2020", "Jan", "Kowalski", gun1.Automatic);
            var ord3 = new Order(gun5.ID, 50, gun5.PrizeForOneShot, "11.11.2020", "Jan", "Kowalski", gun5.Automatic);
            //----------------------------------------------------------------------------------------------------------------------------
            shop.Orders.Add(ord1);
            shop.Orders.Add(ord2);
            shop.Orders.Add(ord3);
            shop.GunList.Add(gun1);
            shop.GunList.Add(gun2);
            shop.GunList.Add(gun3);
            shop.GunList.Add(gun4);
            shop.GunList.Add(gun5);
            //----------------------------------------------------------------------------------------------------------------------------
            var run = true;
            while (run)
            {
                shop.CheckingTheStockStatus();
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("\t\t\t\t USER INTERFACE");
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("a  - Infofmations Magazine l - live o - AddOrder oo - OrderInformation");
                Console.WriteLine("r  - DeleteOrderByID");
                Console.WriteLine("w2 - AdGun w3 - AddBullets w4 - RenameGun w5 - PrizeForOneShot w6 - DeleteGun");
                Console.WriteLine("t1 -TotalBill t2 - FullBillInformation t3 - GenerateABill");
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
                    case "w2":
                        shop.AdGun();
                        break;
                    case "w3":
                        shop.AddBullets();
                        break;
                    case "w4":
                        shop.RenameGun();
                        break;
                    case "w5":
                        shop.PrizeForOneShot();
                        break;
                    case "w6":
                        shop.DeleteGun();
                        break;
                    case "t1":
                        shop.DeleteGun();
                        break;
                    case "t2":
                        shop.FullBillInformation();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Such an operation does not exist");
                        break;
                }
            }
            //----------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Thank you for your hard work !!!");
            Console.WriteLine("See you ;)");
            Console.ReadKey();
        }
    }
}
