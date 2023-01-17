using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.Threading.Tasks;

namespace DemoApp
{
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //GetLocation();
        }

        private async void GetLocation()
        {
            //var status = await CheckAndRequestLocationPermission();

            //if (status == PermissionStatus.Granted)
            //{
            //    var location = await Geolocation.GetLocationAsync();
            //}
        }

        //private async Task<PermissionStatus> CheckAndRequestLocationPermission()
        //{
            //var status = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>

            //if (status == PermissionStatus.Granted)
            //    return status;

            //if (status == PermissionStatus.Denied && DeviceInfo.Platform == DevicePlatform.iOS)
            //{
            //    return status;
            //}

            //status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
            //return status;
        //}
    }
}