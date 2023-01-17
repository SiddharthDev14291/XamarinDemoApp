using System;
using System.Collections.Generic;
using DemoApp.Model;
using SQLite;
using Xamarin.Forms;

namespace DemoApp
{
    public partial class NewTravelPage : ContentPage
    {
        public NewTravelPage()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {
            Post post = new Post()
            {
                Experience = experienceEntry.Text
            };

            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Post>();
                int rows = conn.Insert(post);

                if (rows > 0)
                {
                    DisplayAlert("Success", "Data successfully added", "Ok");
                }
                else
                {
                    DisplayAlert("Failure", "Failed to add data", "Ok");
                }
            }
        }
    }
}

