using Xamarin.Forms;

[assembly: Dependency(typeof(DemoCodigo200.iOS.iOSDeviceService))]
namespace DemoCodigo200.iOS
{
    public class iOSDeviceService : DemoCodigo200.Services.IDeviceService
    {
        public string CurrentPlattform => "iOS";
    }
}