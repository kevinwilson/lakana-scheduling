using System;
using System.Collections;
using System.Linq;
using LakanaScheduling.Models;
using Xamarin.Forms;
using SQLite;
using SQLiteNetExtensions.Extensions;

namespace LakanaScheduling.Views
{
    public partial class ManageUsers : ContentPage
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<TabletUser>();
                var users = conn.GetAllWithChildren<TabletUser>().ToList();
                
           
                userListView.ItemsSource = users;
            }
        }

        async void ToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Views.AddEditUser());
        }

        async void userListView_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var selectedUser = userListView.SelectedItem as TabletUser;

            if (selectedUser != null)
            {
                await Navigation.PushAsync(new AddEditUser(selectedUser));
            }
        }
    }
}
