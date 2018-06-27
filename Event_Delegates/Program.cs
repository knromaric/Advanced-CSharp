using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Pursuit of happiness" };
            var videoEncoder = new VideoEncoder();// publisher
            var mailService = new MailService(); // subscriber
            var messageService = new MessageService(); // subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnvideoEncoded;
            videoEncoder.Encode(video);
        }
    }

}
