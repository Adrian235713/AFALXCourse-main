using System;
using System.Collections.Generic;
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
        public string Date;
        public string Name;
        public string LastName;
        public string NameAndLastName;
        public Order(string idGun, int numberOfShots, string date, string name, string lastName)
        {
            UniqueIdOrder = generateUniqueID();
            IdGun = idGun;
            NumberOfShots = numberOfShots;
            Date = date;
            Name = name;
            LastName = lastName;
            NameAndLastName = name.ToLower().Trim() + lastName.ToLower().Trim();
        }

        private string generateUniqueID()
        {
            long ticks = DateTime.Now.Ticks;
            string guid = Guid.NewGuid().ToString();
            return ticks.ToString() + "-" + guid;
        }

        public void Informations()
        {
            Console.WriteLine($"UniqueIdOrder \t {UniqueIdOrder}");
            Console.WriteLine($"NumberOfShots \t {NumberOfShots}");
            Console.WriteLine($"Date \t {Date} Person \t {Name} {LastName}");
        }
    }
}
