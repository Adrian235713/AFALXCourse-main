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

        }

        public void UpdateOrder()
        {

        }

        public void DeleteOrder()
        {

        }
    }
}
