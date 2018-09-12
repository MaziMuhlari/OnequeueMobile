using System;
using Onequeue.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Push;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Onequeue
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new PushNotificationPromptPage();
        }

        protected override void OnStart()
        {
            AppCenter.Start(
                "android=3a767606-d001-4820-a246-a159de30b43e;" +
                "ios=b7a9d74b-c562-460c-85d0-cfa3faae754e;",
                typeof(Analytics), typeof(Crashes), typeof(Push));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
