using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guardianEyeMAUI
{
    public static class Constants
    {
        public static string baseAddress = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5174/api/ScaffDetections" : "http://localhost:5174/api/ScaffDetections";
    }
}
