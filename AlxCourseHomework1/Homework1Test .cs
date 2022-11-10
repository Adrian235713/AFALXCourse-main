using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework1
{
    internal class Program
    {

        static void Run(List<Email> emails)
        {
            EmailService emailService = new EmailService();
            foreach (Email email in emails)
            {
                emailService.SendEmail(email);
            }
        } 

        static List<Email> CreateEmails(int a)
        {
            List<Email> emails = new List<Email>();
            for (int i = 0; i < a; i++)
            {
                Email email = new Email("Ala1", "Tomek", "c", "Ala ma kota");
                emails.Add(email);
            }
            return emails;
        }

        static void Main(string[] args)
        {

            //public string From;
            //public string To;
            //public string Subject;
            //public string Message;

            Run(CreateEmails(5));

            Console.ReadKey();
        }
    }
}
