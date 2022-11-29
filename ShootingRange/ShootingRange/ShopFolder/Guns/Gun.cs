using System;

namespace ShootingRange.Shop.Guns
{
    internal class Gun : GunsInterface
    {
        public string ID;
        public string name;
        public int bullets;
        public double prizeForOneShot;
        public bool Automatic;

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
        public Gun(string name, int bullets, double prizeForOneShot, bool automatic)
        {
            ID = generateUniqueID();
            Name = name;
            Bullets = bullets;
            Automatic = automatic;
            if (automatic)
            {
                PrizeForOneShot = prizeForOneShot - prizeForOneShot*0.2;
            }
            else
            {
                PrizeForOneShot = prizeForOneShot;
            }
            
        }
        //-----------------------------------------------------------------------
        //Methods
        public void Information()
        {
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine($"ID \t {ID} \n");
            Console.WriteLine($"Name \t\t\t\t {Name}");
            Console.WriteLine($"Bullets \t\t\t {Bullets}");
            Console.WriteLine($"PrizeForOneShot \t\t {PrizeForOneShot}");
            if (Automatic)
            {
                Console.WriteLine($"Automatic \t\t\t {Automatic} 20% discount included");
            }
            else
            {
                Console.WriteLine($"Automatic \t {Automatic} No discount");
            }
            Console.WriteLine("-----------------------------------------------------------------------");
        }

        public void RenameGun()
        {
            Console.WriteLine($"Old Name - {name}");
            Console.WriteLine("New name ?");
            string inp = Console.ReadLine();
            Name = inp;
        }

        public void StausEditionAmmunition()
        {
            Console.WriteLine($"bullets - {bullets}");
            Console.WriteLine("Change ?");
            int change = Int32.Parse(Console.ReadLine());
            bullets = bullets + change;
        }


        public void EditionAmmunitionOrder(int change)
        {
                bullets = bullets - change;
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
    }
}
