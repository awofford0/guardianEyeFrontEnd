using Android.App;
using Android.Content.PM;
using Android.OS;

namespace guardianEyeMAUI
{
    [Activity(Label = "GuardianEye", Icon = "@drawable/guardian_eye", Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        internal static readonly string Channel_ID = "Test";
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            CreateNotificationChannel();
        }

        private void CreateNotificationChannel()
        {
            //var channel = new NotficationChannel(Channel_ID,"Test Channel", NotificationImportance.Default);
        }
    }
}