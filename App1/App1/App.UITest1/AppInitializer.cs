using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Configuration;

namespace App.UITest1
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android
                    //.DeviceSerial("emulator-5554")
                    .ApkFile("com.companyname.App1.apk")
                    .StartApp(AppDataMode.Clear);
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}