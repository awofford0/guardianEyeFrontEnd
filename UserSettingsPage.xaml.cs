namespace guardianEyeMAUI;

public partial class UserSettingsPage : ContentPage
{
	public UserSettingsPage()
	{
		InitializeComponent();
	}

    private async void Close_Settings_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("//API_Main");
    }

    private void Human_Notifs_Toggled(object sender, ToggledEventArgs e)
    {
        //hooks up to FCM notification provider method, toggles boolean to allow/block human notifications
    }

    private void Animal_Notifs_Toggled(object sender, ToggledEventArgs e)
    {
        //hooks up to FCM notification provider method, toggles boolean to allow/block animal notifications

    }

    private void Car_Notifs_Toggled(object sender, ToggledEventArgs e)
    {
        //hooks up to FCM notification provider method, toggles boolean to allow/block car notifications

    }
}