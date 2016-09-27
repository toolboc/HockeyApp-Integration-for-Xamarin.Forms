using System;
using System.Collections.Generic;
using System.Text;

namespace Forms.Shared.Xaml.Services
{
    public interface IMetricsManagerService
    {
        void TrackEvent(string eventName);
    }
}
