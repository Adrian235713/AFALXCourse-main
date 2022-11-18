using Spotkanie3.Lesons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotkanie3
{
    internal class Run
    {

   

        static void Main(string[] args)
        {

            List<Book> books = new List<Book>();
            while (true)
            {
                string inp = Console.ReadLine();    
                if(inp.ToLower() == "l")
                {
                    break;
                }
                else
                {
                    Book book = new Book(inp);
                    books.Add(book);
                }
            }



        }
    }
}
