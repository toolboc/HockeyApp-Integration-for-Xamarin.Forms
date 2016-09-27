using System;
using System.Collections.Generic;
using System.Text;

#if __IOS__ || __DROID__ 
using HockeyApp;
#endif
[assembly: Xamarin.Forms.Dependency(typeof(Forms.Shared.Xaml.Services.MetricsManagerService))]
namespace Forms.Shared.Xaml.Services
{
    class MetricsManagerService : IMetricsManagerService
    {
        public void TrackEvent(string eventName)
        {
#if __IOS__ || __DROID__ 
            MetricsManager.TrackEvent(eventName);
#endif

#if WINDOWS_UWP || WINDOWS_PHONE_APP || WINDOWS_APP
            Microsoft.HockeyApp.HockeyClient.Current.TrackEvent(eventName);
#endif

        }
    }
}
