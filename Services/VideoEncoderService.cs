
using static System.Console;
using EvnetsAndDelegates.Models;

namespace EvnetsAndDelegates.Services
{
    public class VideoEncoderService
    {
        public delegate void VideoEncoderEventHandler(object source, EventArgs args);

        public event VideoEncoderEventHandler VideoEncoded;

        public void Encode(VideoModel video)
        {
            WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            VideoEncoded?.Invoke(this, EventArgs.Empty);
        }
    }
}