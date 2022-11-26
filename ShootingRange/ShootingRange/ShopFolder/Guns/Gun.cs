using System;

namespace ShootingRange.Shop.Guns
{
    internal class Gun : GunsInterface
    {
        private string ID;
        private string name;
        private int bullets;
        private double prizeForOneShot;

        private string generateUniqueID()
        {
            long ticks = DateTime.Now.Ticks;
            string guid = Guid.NewGuid().ToString();
            return ticks.ToString() + "-" + guid;
        }

        //-----------------------------------------------------------------------
        //Data Validation
        public string Name
        {
            get { return name; }
            set { 
                if(string.IsNullOrEmpty(value) || value.Length >50)
                {
                    value = "None";
                }
                else
                {
                    name = value;
                }    
            }
        }

        public int? Bullets
        {
            get { return bullets; }
            set { 
                if (value < 0)
                {
                    bullets = (Int32)value;
                }
                else
                {
                    bullets = (Int32)value;
                }   
            }
        }

        public double PrizeForOneShot
        {
            get { return prizeForOneShot; }
            set 
            { 
                if (value < 1)
                {
                    prizeForOneShot = 1;
                }
                else
                {
                    prizeForOneShot = value;
                }
            }
        }
        //-----------------------------------------------------------------------
        public Gun(string name, int bullets, double prizeForOneShot)
        {
            ID = generateUniqueID();
            Name = name;
            Bullets = bullets;
            PrizeForOneShot = prizeForOneShot;
        }
        //-----------------------------------------------------------------------
        //Methods
        public void Information()
        {
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine($"ID - {ID}");
            Console.WriteLine($"Name - {Name}");
            Console.WriteLine($"Bullets - {Bullets}");
            Console.WriteLine($"PrizeForOneShot - {PrizeForOneShot}");
            Console.WriteLine("-----------------------------------------------------------------------");
        }

        public void RenameGun()
        {
            Console.WriteLine($"Name - {name}");
            Console.WriteLine("New name ?");
            string inp = Console.ReadLine();

        }

        public void StausEditionAmmunition()
        {
            Console.WriteLine($"bullets - {bullets}");
            Console.WriteLine("Change ?");
            int change = Int32.Parse(Console.ReadLine());
            if (bullets - change < bullets)
                Console.WriteLine("Not enough bullets in stock");
            else
                bullets = bullets + change;
        }

        public void StatusPrizeForOneShot()
        {
            Console.WriteLine($"PrizeForOneShot - {prizeForOneShot}");
            Console.WriteLine("Change ?");
            int change = Int32.Parse(Console.ReadLine());
            if (prizeForOneShot < 0)
                Console.WriteLine("You cannot set a price lower than zero");
            else
                prizeForOneShot = change;
        }

        //-----------------------------------------------------------------------
    }
}
