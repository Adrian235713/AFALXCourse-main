using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AlxCourseHomework1
{

    public class Email
    {
        public string From;
        public string To;
        public string Subject;
        public string Message;

        public Email(string froms, string to, string subject, string message)
        {
            this.From = froms;
            this.To = to;
            this.Subject = subject;
            this.Message = message;
        }


    }
}
