namespace EventsAndDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {

            VideoEncoder encoder = new VideoEncoder();
            MessageService messageService = new MessageService();
            MailService mailService = new MailService();

            Video video = new Video("sailing.mp4");


            Console.WriteLine("");
            Console.WriteLine("test case 1");
            Console.WriteLine("");
            encoder.VideoEncoded += messageService.SendMessage;
            encoder.VideoEncoded += mailService.SendMail;
            encoder.Encode(video);


            Console.WriteLine("");
            Console.WriteLine("test case 2");
            Console.WriteLine("");
            encoder.VideoEncoded -= messageService.SendMessage;
            encoder.Encode(video);


            Console.WriteLine("");
            Console.WriteLine("test case 3");
            Console.WriteLine("");
            encoder.VideoEncoded += messageService.SendMessage;
            encoder.VideoEncoded -= mailService.SendMail;

            encoder.Encode(video);



            Console.WriteLine("");
            Console.WriteLine("test case 4");
            Console.WriteLine("");
            encoder.VideoEncoded += mailService.SendMail;
            encoder.Encode(video);

            Console.WriteLine("When adding new services that depend on the encoding service,");
            Console.WriteLine("we don't have to modify the encoding service code.");
            Console.WriteLine("This means we don't have to rebuild the encoder service code");
            Console.WriteLine("because they are loosely coupled!");


        }
    }


 
}