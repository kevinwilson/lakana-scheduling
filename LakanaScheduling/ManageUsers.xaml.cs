using System;
using System.Collections.Generic;
using SQLite;
using Xamarin.Forms;
using LakanaScheduling.Model;

namespace LakanaScheduling
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
                var users = conn.Table<TabletUser>().ToList();
                userListView.ItemsSource = users;
            }
        }

        async void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddEditUser());
        }

        async void userListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedUser = userListView.SelectedItem as User;

            if (selectedUser != null)
            {
                await Navigation.PushAsync(new UserDetailPage(selectedUser));
            }
        }
    }
}
