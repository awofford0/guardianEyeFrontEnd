using Android.App;
using Android.Runtime;

namespace guardianEyeMAUI
{
    [Application(UsesCleartextTraffic = true, Label = "My Maui App")]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}