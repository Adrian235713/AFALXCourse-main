using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingRange.Shop.Guns
{
    internal class Gun
    {
        public string name;
        public int bullets;
        public double prizeForOneShot;

        public string Name
        {
            get { return name; }
            set { 
                if(string.IsNullOrEmpty(value))
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
            set { if (value < 0)
                {
                    bullets = (int)value;
                }
                else
                {
                    value = 0;
                }   
            }
        }

        public Gun(string name, int bullets)
        {
            Name = name;
            Bullets = bullets;
        }
    }
}
