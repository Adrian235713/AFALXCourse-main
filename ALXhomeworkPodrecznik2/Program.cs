using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXhomeworkPodrecznik2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Exercise1");
            Console.WriteLine("---------------------------------------------------");
            Exercise1 exercise1 = new Exercise1();
            exercise1.exercise1();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Exercise2");
            Console.WriteLine("---------------------------------------------------");
            Exercise2 exercise2 = new Exercise2();
            exercise2.MonthsIterationList();
            exercise2.MonthsIterationArray();



            Console.ReadKey();

        }
    }
}
