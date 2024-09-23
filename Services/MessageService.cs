using static System.Console;

namespace EvnetsAndDelegates.Services
{
    public class MessageService
    {
        public void SendMessage(VideoEncoderService service)
        {
            service.VideoEncoded += OnVideoEncoded;
        }

        private void OnVideoEncoded(object source, EventArgs args)
        {
            WriteLine("MessageService: Senidng message...");
        }
    }
}