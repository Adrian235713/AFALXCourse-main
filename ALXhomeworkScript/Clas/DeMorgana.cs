using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXhomeworkScript.Clas
{
    internal class DeMorgana
    {
        //(∼(p∧q))⇔((∼p)∨(∼q))
        public static void deMorgana(bool p, bool q)
        {
            bool equationLeftSide = !(p && q);
            bool rightSideEquation = !p || !q;
            bool equal = (equationLeftSide == rightSideEquation) ? true : false;
            Console.WriteLine($"((∼(p∧q))⇔((∼p)∨(∼q)) \t p = {p} q = {q} \t {equal}");
        }

        public static void deMorgana(int p_int, int q_int)
        {
            bool p = Convert.ToBoolean(p_int);
            bool q = Convert.ToBoolean(q_int);
            bool equationLeftSide = !(p && q);
            bool rightSideEquation = !p || !q;
            bool equal = (equationLeftSide == rightSideEquation) ? true : false;
            Console.WriteLine($"((∼(p∧q))⇔((∼p)∨(∼q)) \t p = {p} q = {q} \t {equal}");
        }

        public static void deMorganaTest(int numberOfTests)
        {
            Random rnd = new Random();
            for(int i = 0; i < numberOfTests; i++)
            {
                int p = rnd.Next(0,2);
                int q = rnd.Next(0, 2);
                Console.WriteLine();
                Console.WriteLine($"Test {i} for p = {p} q = {q}");
                deMorgana(p, q);
                Console.WriteLine();
            }
        }

    }
}
