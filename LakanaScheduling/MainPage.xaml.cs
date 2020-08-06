using System;
using Xamarin.Forms;
using LakanaScheduling.Resources;

namespace LakanaScheduling
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            AppResources.Culture = new System.Globalization.CultureInfo("en");
            LoggedInStatus.Text = App.IsLoggedIn ? AppResources.LoggedInText : AppResources.LoggedOutText;

          

        }

        public MainPage(string message)
        {
            InitializeComponent();



            AppResources.Culture = new System.Globalization.CultureInfo("en");
            LoggedInStatus.Text = message;
            //LoggedInStatus.Text = App.IsLoggedIn ? AppResources.LoggedInText : AppResources.LoggedOutText;

           

        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            if (!App.IsLoggedIn)
            {
                await DisplayAlert("Error", "Please login to contine", "OK");
            } else
            {
                await Navigation.PushAsync(new ViewEditVillageSchedulePage());
            }
        }

        void Login_Clicked(System.Object sender, System.EventArgs e)
        {
            App.IsLoggedIn = !App.IsLoggedIn;
            Login.Text = App.IsLoggedIn ? AppResources.LogoutText : AppResources.LoginText;

            LoggedInStatus.Text = App.LoggedInUser;
        }

        void ChangeLanguage_Clicked(System.Object sender, System.EventArgs e)
        {

            if (AppResources.Culture.Name.Equals("en"))
            {
                AppResources.Culture = new System.Globalization.CultureInfo("fr");
            }
            else
            {
                AppResources.Culture = new System.Globalization.CultureInfo("en");
            }
 
        }

        async void ManageUsers_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ManageUsers());
        }
    }
}
