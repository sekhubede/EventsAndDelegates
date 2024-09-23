using EvnetsAndDelegates.Models;
using static System.Console;

namespace EvnetsAndDelegates.Services
{
    public class MessageService
    {
        public void SendMessage(VideoEncoderService service)
        {
            service.VideoEncoded += OnVideoEncoded;
        }

        private void OnVideoEncoded(object source, VideoEventArgsModel e)
        {
            WriteLine("MessageService: Senidng message...{0}", e.Video.Title);
        }
    }
}