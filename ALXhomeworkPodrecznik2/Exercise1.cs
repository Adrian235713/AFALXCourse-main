using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXhomeworkPodrecznik2
{
    internal class Exercise1
    {
        private string[] Products = { "A", "B", "C", "D" };
        private double[] Price = {2,4,6,8};

        public void exercise1()
        {
            while (true)
            {
                Console.Write("L - live Products | ");
                foreach (string el in Products)
                {
                    Console.Write($"{el} ");
                }
                Console.WriteLine();
                Console.WriteLine("Choose a product ?");
                string inp = Console.ReadLine().ToUpper();
                if (Products.Contains(inp))
                { 
                    Console.WriteLine($"Price = {Price[Array.IndexOf(Products,inp)]}");
                }
                else if (inp == "L")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("There is no such product");
                }

            }
        }

        public int[,] generateIdentityMatrix(int k)
        {
            int[,] Matrix = new int[k, k];
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (j == i)
                    {
                        Matrix[i, j] = 1;
                    }
                }
            }
            return Matrix;
        }

        public void displayMatrix(int[,] Matrix)
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write($"{Matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static void exercise3()
        {
            List <double> myList = new List<double>();
            while (true)
            {
                Console.WriteLine("l = live | Add a number to the array");
                string inp = Console.ReadLine().ToLower();
                if (inp == "l")
                { 
                    break;
                }
                myList.Add(double.Parse(inp));
            }

            double[] array1 = myList.ToArray();

            Console.WriteLine("by what number to increase ?");
            double inp2 = double.Parse(Console.ReadLine());

            double[] array2 = new double[array1.Length];
            foreach(double x in array1)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
            foreach (double x in array1)
            {
                Console.Write($"{x + inp2} ");
            }
            Console.WriteLine();
        }
    }
}
