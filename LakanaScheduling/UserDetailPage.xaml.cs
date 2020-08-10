using System;
using System.Collections.Generic;
using LakanaScheduling.Models;
using SQLite;

using Xamarin.Forms;

namespace LakanaScheduling
{
    public partial class UserDetailPage : ContentPage
    {
        User selectedUser;

        public UserDetailPage(User selectedUser)
        {
            InitializeComponent();
            this.selectedUser = selectedUser;
            userNameLabel.Text = selectedUser.UserName;
        }

        void UpdateButton_Clicked(System.Object sender, System.EventArgs e)
        {
            selectedUser.UserName = userNameLabel.Text;

            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<User>();
                var rowsInserted = conn.Update(selectedUser);

                if (rowsInserted > 0)
                    DisplayAlert("Success", "User inserted updated", "OK");
                else
                    DisplayAlert("Failure", "User not updated", "OK");
            }

            Navigation.PopAsync();
        }

        void DeleteButton_Clicked(System.Object sender, System.EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<User>();
             
                var rowsInserted = conn.Delete(selectedUser);

                if (rowsInserted > 0)
                    DisplayAlert("Success", "User deleted", "OK");
                else
                    DisplayAlert("Failure", "User not deleted", "OK");
            }
            Navigation.PopAsync();
        }
    }
}
