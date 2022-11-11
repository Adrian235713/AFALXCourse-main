using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ALXhomeworkPodrecznik2
{
    internal class Exercise2
    {
        public string[] MonthsArray =
        { 
        "January",
        "February",
        "March",
        "April",
        "May",
        "June",
        "July",
        "August",
        "September",
        "October = 10",
        "November = 11",
        "December = 12"
        };

        public List<string> MonthsList = new List<string>
        {
        "January",
        "February",
        "March",
        "April",
        "May",
        "June",
        "July",
        "August",
        "September",
        "October = 10",
        "November = 11",
        "December = 12"
        };

        public void MonthsIterationArray()
        {
            Console.WriteLine(MonthsArray);
            foreach(string el in MonthsArray)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine("---------------------------------------------------");
        }

        public void MonthsIterationList()
        {
            Console.WriteLine(MonthsList);
            foreach (string el in MonthsList)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine("---------------------------------------------------");
        }

    }
}
