using System.Windows.Input;
using System.Threading.Tasks;

using Xamarin.Forms;

using VideoXamarin.Services;

namespace VideoXamarin.ViewModels
{
    public class VideoViewModel : BaseViewModel
    {
        CameraService cameraService;

        private string _videoURL;

        public string VideoURL
        {
            get { return _videoURL; }
            set { _videoURL = value; OnPropertyChanged(); }
        }

        public ICommand TakeVideoCommand { get; private set; }


        public VideoViewModel()
        {
            cameraService = new CameraService();
            Task.Run(async () => await cameraService.Init());

            TakeVideoCommand = new Command(async () => await TakeVideo());
  
        }

        private async Task TakeVideo()
        {
            var file = await cameraService.TakeVideo();

            if (file != null)
                VideoURL = file.Path;
        }


    }
}
