using ShootingRange.Shop;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingRange.ShopFolder.OrderFolder
{
    internal class Order 
    {
        public string IdGun;
        public string UniqueIdOrder;
        public int NumberOfShots;
        public double PricePerShot;
        public string Date;
        public string Name;
        public string LastName;
        public string NameAndLastName;
        public bool Ddiscount;
        public double PriceOforder;
        double Dis = 0.2;

        public Order(string idGun, int numberOfShots,double pricePerShot, string date, string name, string lastName, bool discount)
        {
            UniqueIdOrder = generateUniqueID();
            IdGun = idGun;
            NumberOfShots = numberOfShots;
            PricePerShot = pricePerShot;
            Date = date;
            Name = name;
            LastName = lastName;
            NameAndLastName = name.ToLower().Trim() + lastName.ToLower().Trim();
            Ddiscount = discount;
            if (Ddiscount)
            {
                PriceOforder = (NumberOfShots * PricePerShot)*(1- Dis);
            }
            else
            {
                PriceOforder = (NumberOfShots * PricePerShot) * (1 - Dis);
            }

        }

        private string generateUniqueID()
        {
            long ticks = DateTime.Now.Ticks;
            string guid = Guid.NewGuid().ToString();
            return ticks.ToString() + "-" + guid;
        }

        public void Informations()
        {
            Console.WriteLine($"UniqueIdOrder \t {UniqueIdOrder} \n");
            Console.WriteLine($"NumberOfShots \t {NumberOfShots}");
            Console.WriteLine($"Date \t {Date} \t Person \t {Name} {LastName}");
            Console.WriteLine($"Ddiscount {Ddiscount} {Dis*100}% | Before tax {PriceOforder} | After tax {PriceOforder*1.22} \n");
        }
    }
}
