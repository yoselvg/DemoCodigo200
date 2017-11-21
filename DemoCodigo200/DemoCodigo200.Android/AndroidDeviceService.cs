using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DemoCodigo200;
using DemoCodigo200.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(DemoCodigo200.Droid.AndroidDeviceService))]
namespace DemoCodigo200.Droid
{
    public class AndroidDeviceService : IDeviceService
    {
        public string CurrentPlattform => "Android";
    }
}