
using static System.Console;
using EvnetsAndDelegates.Models;

namespace EvnetsAndDelegates.Services
{
    public class VideoEncoderService
    {
        // Custom delegate
        // public delegate void VideoEncoderEventHandler(object source, VideoEventArgsModel args);

        // Publishing an event without sending any additional data
        // public event EventHandler VideoEncoding;
        public event EventHandler<VideoEventArgsModel> VideoEncoded;

        public void Encode(VideoModel video)
        {
            WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(VideoModel video)
        {
            VideoEncoded?.Invoke(this, new VideoEventArgsModel(video));
        }
    }
}