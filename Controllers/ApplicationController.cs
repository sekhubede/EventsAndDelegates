using EvnetsAndDelegates.Models;
using EvnetsAndDelegates.Services;

namespace EvnetsAndDelegates.Controllers
{
    public class ApplicationController
    {
        private VideoEncoderService videoEncoder;

        public ApplicationController()
        {
            videoEncoder = new VideoEncoderService();
        }

        public void Run()
        {
            var video = new VideoModel { Title = "Video 1" };

            var mailService = new MailService();
            mailService.SendMail(videoEncoder);

            var messageService = new MessageService();
            messageService.SendMessage(videoEncoder);

            videoEncoder.Encode(video);
        }
    }
}