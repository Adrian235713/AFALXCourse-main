using ShootingRange.Shop.Guns;
using ShootingRange.ShopFolder.OrderFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingRange.Shop
{
    internal class Shop : ShopInterface
    {
        public List<Gun> GunList = new List<Gun>();
        public List<Order> Orders = new List<Order>();

        public void AdGun()
        {
            try
            {
                Console.WriteLine("Give the name of the weapon");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the number of bullets");
                int numberOfBullets = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Price per shot");
                double prizeForOneShot = Convert.ToInt64(Console.ReadLine());
                Gun gun = new Gun(name, numberOfBullets, prizeForOneShot);
                GunList.Add(gun);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        public void Infofmations()
        {
            foreach (var gun in GunList)
            {
                gun.Information();
            }
        }

        public void AddOrder()
        {
            bool run = true;
            while (run)
            {
                int i = 0;
                foreach (var gun in GunList)
                {
                    Console.WriteLine($"Enter number {i} to order order the shots");
                    gun.Information();
                    i++;
                }
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("Creating an order: | l - live");
                Console.WriteLine("Enter number");
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
                        Order order = new Order(GunList[int.Parse(inp)].ID, numberOfShots, data, name, lastName);
                        GunList[int.Parse(inp)].EditionAmmunitionOrder(numberOfShots);
                        Orders.Add(order);
                        Console.Clear();
                    }
                    
                } catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
                
            }
        }

        public void OrderInformation()
        {
            foreach(var order in Orders)
            {
                order.Informations();
            }
        }

        public void DeleteOrder()
        {
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
            Console.WriteLine("Order by given ID does not exist");
        }
    }
}
