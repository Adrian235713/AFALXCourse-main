using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ALXhomeworkScript.Clas
{
    internal class Person
    {
        private string Name;
        private string LastName;
        private int Age;
        private double Height;
        private double PESEL;

        public Person(string name, string lastName, int age, double height, double pesel)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            Height = height;
            PESEL = pesel;
        }

        public void PersonInformation()
        {
            Console.WriteLine($"-----------------------------------------------");
            Console.WriteLine($"Name - {Name}");
            Console.WriteLine($"LastName - {LastName}");
            Console.WriteLine($"Age - {Age}");
            Console.WriteLine($"Height - {Height}");
            Console.WriteLine($"PESEL - {PESEL}");
            Console.WriteLine($"-----------------------------------------------");
        }

        public void DayInformation(int day, int month, int year)
        {
            EnumDays days = (EnumDays)day;
            EnumMonth months = (EnumMonth)month;
            Console.WriteLine($"-----------------------------------------------");
            Console.WriteLine($"Hi {Name} {LastName} todya is {days} {months} {year}");
            Console.WriteLine($"-----------------------------------------------");
        }



    }
}
