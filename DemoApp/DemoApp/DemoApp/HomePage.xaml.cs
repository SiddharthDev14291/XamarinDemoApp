using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoApp
{
    public partial class HomePage : TabbedPage
    {
        public HomePage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
        }

        public Task PageClosedTask { get; internal set; }

        private void ToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new NewTravelPage());
        }
    }
}

