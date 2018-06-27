using System;

namespace Event_Delegates
{
    public class MessageService
    {
        public void OnvideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending a text message...  " + args.Video.Title);
        }
    }

}
