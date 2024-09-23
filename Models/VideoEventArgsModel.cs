namespace EvnetsAndDelegates.Models
{
    public class VideoEventArgsModel : EventArgs
    {
        public VideoModel Video { get; }

        public VideoEventArgsModel(VideoModel video)
        {
            Video = video;
        }
    }
}