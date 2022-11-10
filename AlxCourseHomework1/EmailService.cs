using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework1
{
    internal class EmailService
    {

        //public string From;
        //public string To;
        //public string Subject;
        //public string Message;
        public void SendEmail(Email email)
        {
            Console.WriteLine("==================================");
            Console.WriteLine("Wiadmowsc wyslana porawnie");
            Console.WriteLine($"From\t{email.From}");
            Console.WriteLine($"To\t{email.To}");
            Console.WriteLine($"Subject\t{email.Subject}");
            Console.WriteLine($"Message\t{email.Message}");
            Console.WriteLine("================================== \n");
        }

    }
}
