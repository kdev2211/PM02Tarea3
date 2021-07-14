using Xamarin.Forms;

namespace VideoXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.VideoView());
        }
    }
}
