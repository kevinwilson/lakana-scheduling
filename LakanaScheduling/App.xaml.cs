using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.WindowsAzure.MobileServices;

namespace LakanaScheduling
{
    public partial class App : Application
    {
        public static string DatabaseLocation = string.Empty;
        public static MobileServiceClient client = new MobileServiceClient("https://lakana.azurewebsites.net");
        

        public static bool IsLoggedIn = false;
        public static string[] UserRoles = new string[] { "User", "Admin" };
        public static string LoggedInUser = string.Empty;

        public App()
        {
            InitializeComponent();
        }

        public App(string databaseLocation)
        {
            InitializeComponent();
            DatabaseLocation = databaseLocation;
            string setupUserResult = LakanaScheduling.Utilities.TabletUsers.CreateDefaultUser();
            MainPage = new MainMasterDetailPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
