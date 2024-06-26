//using Google.Android.Material.Color.Utilities;

namespace TheBreathingApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OpenBreathing1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BoxBreathing());
        }
        private async void OpenBreathing2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FourSevenEightBreathing());
        }
        private async void OpenBreathing3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AlternateNostrilBreathing());
        }
        private async void OpenBreathing4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HummingBeeBreathing());
        }

    }

}
