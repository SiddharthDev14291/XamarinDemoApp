using System;
using System.Collections.Generic;
using DemoApp.Model;
using SQLite;
using Xamarin.Forms;

namespace DemoApp
{
    public partial class PostDetailPage : ContentPage
    {
        Post selectPost;

        public PostDetailPage(Post selectedPost)
        {
            InitializeComponent();

            this.selectPost = selectedPost;

            experienceEntry.Text = selectedPost.Experience;
        }

        void updateButton_Clicked(System.Object sender, System.EventArgs e)
        {
            selectPost.Experience = experienceEntry.Text;

            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Post>();
                int rows = conn.Update(selectPost);

                if (rows > 0)
                {
                    DisplayAlert("Success", "Data successfully updated", "Ok");
                }
                else
                {
                    DisplayAlert("Failure", "Failed to update data", "Ok");
                }
            }
        }

        void deleteButton_Clicked(System.Object sender, System.EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Post>();
                int rows = conn.Delete(selectPost);

                if (rows > 0)
                {
                    DisplayAlert("Success", "Data successfully deleted", "Ok");
                }
                else
                {
                    DisplayAlert("Failure", "Failed to delete data", "Ok");
                }
            }
        }
    }
}