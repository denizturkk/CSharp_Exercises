using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class MailService
    {
        public void SendMail(object source, VideoEventArgs args)
        {
            Console.WriteLine("mail service sent an e-mail for "+args.Video.Name);
        }
    }
}
