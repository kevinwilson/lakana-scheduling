using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.WindowsAzure.MobileServices;
using LakanaScheduling.Models;
using SQLite;
using SQLiteNetExtensions.Extensions;
using System.Collections.Generic;

namespace LakanaScheduling
{
    public partial class App : Application
    {
        public static string DatabaseLocation = string.Empty;
        public static MobileServiceClient client = new MobileServiceClient("https://lakana.azurewebsites.net");


        public static bool IsLoggedIn = false;
        public static string[] UserRoles;
        public static string LoggedInUser = string.Empty;

        public App()
        {
            InitializeComponent();
        }

        public App(string databaseLocation)
        {
            InitializeComponent();
            DatabaseLocation = databaseLocation;

            // Temp - remove tables in order to check database creation code
            //try
            //{
            //    using (SQLiteConnection conn = new SQLiteConnection(DatabaseLocation))
            //    {
            //        conn.DropTable<TabletUser>();
            //        conn.DropTable<TabletRole>();
            //        conn.DropTable<TabletUserRole>();
            //    }
            //}

            //catch
            //{

            //}
            SetupDatabase();

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

        protected void SetupDatabase()
        {
            int numberOfRoles = 0;

            TabletUser defaultUser;

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(DatabaseLocation))
                {
                    conn.CreateTable<TabletUser>();
                    defaultUser = conn.Get<TabletUser>("admin");
                }
            }
            catch
            {
                using (SQLiteConnection conn = new SQLiteConnection(DatabaseLocation))
                {
                    conn.CreateTable<TabletRole>();
                    numberOfRoles = conn.Table<TabletRole>().Count();
                }

                defaultUser = new TabletUser()
                {
                    Username = "admin",
                    Password = "122662",
                    Firstname = "System",
                    Lastname = "Administrator",
                    AccountActivated = true,
                    Enabled = true
                };

                defaultUser.CreateUser();

                TabletRole existingRole;

                List<TabletRole> roles = new List<TabletRole>();
                roles.Add(new TabletRole() { Role = "admin", RoleDescription = "System administrator" });
                roles.Add(new TabletRole() { Role = "coordinator", RoleDescription = "Study coordinator" });
                roles.Add(new TabletRole() { Role = "supervisor", RoleDescription = "District supervisor" });
                roles.Add(new TabletRole() { Role = "user", RoleDescription = "General user (lowest level permissions)" });

                foreach (var role in roles)
                {
                    try
                    {
                        using (SQLiteConnection conn = new SQLiteConnection(DatabaseLocation))
                        {
                            conn.CreateTable<TabletRole>();
                            existingRole = conn.Get<TabletRole>(role.Role);
                        }
                    }
                    catch
                    {
                        role.CreateRole();
                    }
                }

                defaultUser.Roles = roles;

                using (SQLiteConnection conn = new SQLiteConnection(DatabaseLocation))
                {
                    conn.CreateTable<TabletUserRole>();
                    conn.UpdateWithChildren(defaultUser);
                }

                // Test roles have saved
                using (SQLiteConnection conn = new SQLiteConnection(DatabaseLocation))
                {
                    var kw = conn.GetWithChildren<TabletUser>("admin");
                }
            }
        }
    }   
}
