using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class MessageService
    {

        public void SendMessage(object source,VideoEventArgs args){

            Console.WriteLine("message service sent a message for "+args.Video.Name);
        }
    }
}
