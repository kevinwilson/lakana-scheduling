using System;
using System.Collections.Generic;
using LakanaScheduling.Models;
using SQLite;
using SQLiteNetExtensions.Extensions;
using System.Text.RegularExpressions;
using Xamarin.Forms;


namespace LakanaScheduling.Views
{
    public partial class AddEditUser : ContentPage
    {
        private SaveMode action;
        private TabletUser currentUser;
        private bool isValid;

        public AddEditUser()
        {
            InitializeComponent();
            
            action = SaveMode.Add;
            currentUser = new TabletUser();
            DisplayData();
        }

        public AddEditUser(TabletUser user)
        {
            InitializeComponent();

            action = SaveMode.Edit;
            currentUser = user;
            DisplayData();
        }

        private void DisplayData()
        {
            // Show/hide based on enum

            if (action == SaveMode.Edit)
            {
                Username.IsEnabled = false;
                Password.IsVisible = false;
                PasswordConfirm.IsVisible = false;
            } 

            // Populate fields

            Username.Text = currentUser.Username;
            Firstname.Text = currentUser.Firstname;
            Lastname.Text = currentUser.Lastname;
            Enabled.IsChecked = currentUser.Enabled;
            Activated.IsChecked = currentUser.AccountActivated;

            // Populate roles

            var allRoles = TabletRole.GetTabletRoles();
            for (int i=0; i < allRoles.Count; i++)
            {
                CheckBox c = new CheckBox() { IsChecked = currentUser.Roles.Contains(allRoles[i]), ClassId = allRoles[i].Role };
                c.CheckedChanged += (sender, e) =>
                {
                    TabletRole currentRole = new TabletRole() { Role = ((CheckBox)sender).ClassId };
                    if (e.Value == true && !currentUser.Roles.Contains(currentRole))
                        currentUser.Roles.Add(currentRole);
                    else
                        currentUser.Roles.Remove(currentRole);
                };
                RoleGrid.Children.Add(c, 0, i + 1);
                RoleGrid.Children.Add(new Label { Text = allRoles[i].Role, Margin = new Thickness { Top = 6 } }, 1, i + 1);
            }
        }

        async void DeleteButton_Clicked(System.Object sender, System.EventArgs e)
        {
            var delete = await DisplayAlert("Delete", "Are you sure you want to delete this user?", "Yes", "No");
            if (delete)
            {
                currentUser.Delete();
            }
            await Navigation.PopAsync();
        }

        async void SaveButton_Clicked(System.Object sender, System.EventArgs e)
        {
            bool IsValid = false;
            
            if (Username.Text != string.Empty && Firstname.Text != string.Empty && Lastname.Text != string.Empty)
            {
                IsValid = true;
            } else {
                Status.Text = "Please complete all fields.";
            }
     
            if (action == SaveMode.Add)
            {
                if (Password.Text.Length != 6 || PasswordConfirm.Text.Length != 6 || Password.Text != PasswordConfirm.Text || !Regex.IsMatch(Password.Text, "^\\d{6}$"))
                {
                    IsValid = false;
                    Status.Text = "Please enter a valid 6 digit PIN and ensure the confirmation matches.";
                }
            } 

            if(IsValid)
            {
                currentUser.Save();
                await Navigation.PopAsync();
            }
        }

        void Enabled_CheckedChanged(System.Object sender, Xamarin.Forms.CheckedChangedEventArgs e)
        {
            currentUser.Enabled = e.Value;
        }

        void Activated_CheckedChanged(System.Object sender, Xamarin.Forms.CheckedChangedEventArgs e)
        {
            currentUser.AccountActivated = e.Value;
        }

        void Username_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            currentUser.Username = e.NewTextValue;
        }

        void Password_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            currentUser.Password = e.NewTextValue;
        }

        void Firstname_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            currentUser.Firstname = e.NewTextValue;
        }

        void Lastname_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            currentUser.Lastname = e.NewTextValue;
        }

        
    }
}
