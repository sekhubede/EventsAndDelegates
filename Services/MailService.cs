using static System.Console;

namespace EvnetsAndDelegates.Services
{
    public class MailService
    {
        public void SendMail(VideoEncoderService service)
        {
            service.VideoEncoded += OnVideoEncoded;
        }

        public void OnVideoEncoded(object source, EventArgs args)
        {
            WriteLine("MailService: Sending an email...");
        }
    }
}