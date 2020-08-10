using System;
using System.Collections.Generic;
using LakanaScheduling.Models;

using Xamarin.Forms;

namespace LakanaScheduling.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void Login_Clicked(System.Object sender, System.EventArgs e)
        {
            var user = TabletUser.AuthenticateUser(Username.Text, Password.Text);

            if (user != null && user.Enabled)
            {
                App.IsLoggedIn = true;
                App.LoggedInUser = user.Username;
                if (!user.AccountActivated) user.ToggleAccountActivation();
                await Navigation.PopModalAsync();
            }
            else
            {
                App.IsLoggedIn = false;
                Password.Text = string.Empty;
                Password.Focus();
                LoggedInStatus.Text = "Invalid username and/or password.";
            }
        }
    }
}

 