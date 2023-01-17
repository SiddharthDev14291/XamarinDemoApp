using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var assembly = typeof(MainPage);
            iconImage.Source = ImageSource.FromResource("DemoApp.Assets.Images.travelling.png",assembly);
        }

        private void loginClicked_Clicked(System.Object sender, System.EventArgs e)
        {
            bool userNameEmpty = string.IsNullOrEmpty(username.Text);
            bool passwordEmpty = string.IsNullOrEmpty(password.Text);

            if (userNameEmpty || passwordEmpty)
            {
            }
            else
            {
                Navigation.PushAsync(new HomePage());
            }
        }
    }
}

