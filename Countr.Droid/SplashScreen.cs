using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace Countr.Droid
{
    [Activity(
        Label = "Countr"
        , MainLauncher = true
        , Icon = "@mipmap/ic_launcher"
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }

        protected override void OnCreate(Android.OS.Bundle bundle) //adds an override for the Oncreate method
        {
            base.OnCreate(bundle);

            AppCenter.Start("<4776ae4f-07b4-43d4-8f89-63939309c3da>",
                           typeof(Analytics),
                           typeof(Crashes));
        }
    }
}



