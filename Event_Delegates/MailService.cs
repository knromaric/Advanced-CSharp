using System;

namespace Event_Delegates
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: Sending a mail : " + e.Video.Title);
        }
    }

}
