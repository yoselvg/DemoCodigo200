using DemoCodigo200.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoCodigo200
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var deviceService = DependencyService.Get<IDeviceService>();
            LabelTitle.Text = "Welcome to Xamarin Forms from " + deviceService.CurrentPlattform;
        }
    }
}
