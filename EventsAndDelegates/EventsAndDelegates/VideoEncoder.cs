using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {

        //define a delegate
        //define an event based on that delegate
        //raise the event 

        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(Video video) {

            Console.WriteLine("encoding video");

            loadBar();
            OnVideoEncoded(video);
        }

    
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded!=null)
            {
                VideoEncoded(this, new VideoEventArgs(){Video=video});
            }

        }





















        public void loadBar()
        {
            Console.WriteLine("waiting for services!");
            String printedMessage = "%";
            int pageLoader = 25;
            int loadSpeed = 8;
            int loadConstant = 400;


            for (int i = 1; i <= pageLoader; i++)
            {
              
                Console.Write("#");
               
                Thread.Sleep(loadConstant / loadSpeed);
                
            }

            Console.WriteLine("");

        }

    }
}
