using ShootingRange.Shop.Guns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingRange.Shop
{
    internal class Shop : ShopInterface
    {

        private List<Gun> GunList = new List<Gun>();

        public void AddGun()
        {
            Console.WriteLine("Gun Name");

            Gun g = new Gun();
        }

        public void Infofmations()
        {

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
