using DemoCodigo200.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(DemoCodigo200.UWP.UwpDeviceService))]
namespace DemoCodigo200.UWP
{
    public class UwpDeviceService : IDeviceService
    {
        public string CurrentPlattform => "Universal Windows Plattform (UWP)";
    }
}
