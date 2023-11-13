using guardianEyeMAUI.Services;
using Microsoft.Maui.Controls;
namespace guardianEyeMAUI
{
    public partial class API_Main : ContentPage
    {
        IDetectionServices _service;
        public API_Main(IDetectionServices service)
        {
            InitializeComponent();
            _service = service;
            _service.SendToken(Preferences.Get("DeviceToken", "beef"));
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await _service.RefreshDataAsync();
        }

        private async void SettingsButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//UserSettingsPage");
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        private async void SwapButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//MainPage");
        }
    }
}