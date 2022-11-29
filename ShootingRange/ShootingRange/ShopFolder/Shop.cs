using ShootingRange.Shop.Guns;
using ShootingRange.ShopFolder.OrderFolder;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShootingRange.Shop
{
    internal class Shop : ShopInterface
    {
        public List<Gun> GunList = new List<Gun>();
        public List<Order> Orders = new List<Order>();

        //----------------------------------------------------------------------------------------------------------------------------
        //                              Magazine
        //----------------------------------------------------------------------------------------------------------------------------
        public void CheckingTheStockStatus()
        {
            foreach(var gun in GunList)
            {
                if (gun.Bullets < 0)
                {
                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    Console.WriteLine("\t\t\t URGENT!");
                    Console.WriteLine("Insufficient amount of ammo in storage !!!");
                    Console.WriteLine($"gun \t {gun.bullets} bulets status");
                    Console.WriteLine($"\t ID {gun.ID}");
                    Console.WriteLine("Replenish the stock or delete the order");
                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                }
            }
        }

        public void AdGun()
        {
            Console.Clear();
            try
            {
                Console.WriteLine("Give the name of the weapon");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the number of bullets");
                int numberOfBullets = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Price per shot");
                double prizeForOneShot = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Automatic");
                bool automatic = bool.Parse(Console.ReadLine());
                Gun gun = new Gun(name, numberOfBullets, prizeForOneShot, automatic);
                GunList.Add(gun);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        public void Infofmations()
        {
            Console.Clear();
            foreach (var gun in GunList)
            {
                gun.Information();
            }
        }

        public void AddBullets()
        {
            bool run = true;
            while (run)
            {
                Console.Clear();
                int i = 0;
                foreach (var gun in GunList)
                {
                    Console.WriteLine($"Enter number {i} to swap the number of bullets");
                    gun.Information();
                    i++;
                }
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("Creating an order: | l - live");
                Console.WriteLine("Enter number of gun ;)");
                Console.WriteLine("-----------------------------------------------------------------------");
                string inp = Console.ReadLine().ToLower().Trim();
                try
                {
                    if (inp == "l")
                    {
                        break;
                    }
                    else
                    {
                        GunList[int.Parse(inp)].StausEditionAmmunition();
                    }

                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }

            }
        }

        public void DeleteGun()
        {
            Console.Clear();
            var i = 0;
            Console.WriteLine("Enter ID Gun you want to remove");
            var inp = Console.ReadLine().ToLower().Trim();
            foreach (var gun in GunList)
            {
                if (inp == gun.ID)
                {
                    GunList.RemoveAt(i);
                    Console.WriteLine("The Gun has been removed");
                    break;
                }
                i++;
            }
        }

        public void RenameGun()
        {
            Console.Clear();
            var i = 0;
            Console.WriteLine("Enter ID Gun you want to Rename");
            var inp = Console.ReadLine().ToLower().Trim();
            foreach (var gun in GunList)
            {
                if (inp == gun.ID)
                {
                    GunList[i].RenameGun();
                    break;
                }
                i++;
            }
        }

        public void PrizeForOneShot()
        {
            Console.Clear();
            var i = 0;
            Console.WriteLine("Change PrizeForOneShot Enter ID Gun");
            var inp = Console.ReadLine().ToLower().Trim();
            foreach (var gun in GunList)
            {
                if (inp == gun.ID)
                {
                    GunList[i].StatusPrizeForOneShot();
                    break;
                }
                i++;
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------
        //                              Orders
        //----------------------------------------------------------------------------------------------------------------------------
        public void AddOrder()
        {
            bool run = true;
            while (run)
            {
                Console.Clear();
                int i = 0;
                foreach (var gun in GunList)
                {
                    Console.WriteLine($"Enter number {i} to order order the shots");
                    gun.Information();
                    i++;
                }
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("Creating an order: | l - live");
                Console.WriteLine("Enter number of Gun ;)");
                Console.WriteLine("-----------------------------------------------------------------------");
                string inp = Console.ReadLine().ToLower().Trim();
                try
                {
                    if (inp == "l")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Number of Shots ?");
                        int numberOfShots = int.Parse(Console.ReadLine());
                        Console.WriteLine("Give the date");
                        string data = Console.ReadLine().ToLower();
                        Console.WriteLine("Name");
                        string name = Console.ReadLine().ToLower();
                        Console.WriteLine("Last Name");
                        string lastName = Console.ReadLine().ToLower();
                        Order order = new Order(GunList[int.Parse(inp)].ID, numberOfShots, GunList[int.Parse(inp)].PrizeForOneShot, data, name, lastName, GunList[int.Parse(inp)].Automatic);
                        GunList[int.Parse(inp)].EditionAmmunitionOrder(numberOfShots);
                        Orders.Add(order);
                        Console.Clear();
                    }
                    
                } catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
            Console.Clear();
        }

        public void OrderInformation()
        {
            Console.Clear();
            foreach (var order in Orders)
            {
                order.Informations();
            }
        }

        public void DeleteOrder()
        {
            Console.Clear();
            OrderInformation();
            var i = 0;
            Console.WriteLine("Enter the order you want to remove");
            var inp = Console.ReadLine().ToLower().Trim();
            foreach (var order in Orders)
            {
                if (inp == order.UniqueIdOrder)
                {
                    foreach(var gun in GunList)
                    {
                        if(gun.ID == order.IdGun)
                        {
                            gun.EditionAmmunitionOrder(-order.NumberOfShots);
                        }
                    }
                    Console.WriteLine("The order has been removed from the system");
                    Orders.RemoveAt(i);
                    break;
                }
                i++;
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------
        //                          Bill
        //----------------------------------------------------------------------------------------------------------------------------
        public void FullBillInformation()
        {
            Console.Clear();
            Console.WriteLine("Enter Last Name");
            var firstName = Console.ReadLine().ToLower().Trim();
            Console.WriteLine("Enter the username");
            var lastName = Console.ReadLine().ToLower().Trim();
            double sum = 0;
            foreach(Order order in Orders)
            {
                if (order.NameAndLastName == firstName + lastName)
                {
                    sum += order.PriceOforder;
                }
            }
            Console.WriteLine("/////////////////////////////////////////////////////////////");
            Console.WriteLine($"\tTotal price without tax {sum}zł | with tax {sum*1.22}zł");
            Console.WriteLine("/////////////////////////////////////////////////////////////");
            Console.WriteLine();
        }

        //----------------------------------------------------------------------------------------------------------------------------
    }
}
