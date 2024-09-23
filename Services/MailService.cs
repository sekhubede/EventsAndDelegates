using EvnetsAndDelegates.Models;
using static System.Console;

namespace EvnetsAndDelegates.Services
{
    public class MailService
    {
        public void SendMail(VideoEncoderService service)
        {
            service.VideoEncoded += OnVideoEncoded;
        }

        public void OnVideoEncoded(object source, VideoEventArgsModel e)
        {
            WriteLine("MailService: Sending an email...{0}", e.Video.Title);
        }
    }
}