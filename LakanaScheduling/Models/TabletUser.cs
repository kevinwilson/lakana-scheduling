using System;
using System.Collections.Generic;
using SQLite;
using SQLiteNetExtensions.Attributes;
using SQLiteNetExtensions.Extensions;

namespace LakanaScheduling.Models
{
    [Table("TabletUser")]
    public class TabletUser
    {

        [PrimaryKey]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public bool Enabled { get; set; }
        public bool AccountActivated { get; set; }
        public DateTime ServerUpdated { get; set; }
        public DateTime ClientUpdated { get; set; }

        [ManyToMany(typeof(TabletUserRole))]
        public List<TabletRole> Roles { get; set;  }

        public TabletUser()
        {
            Roles = new List<TabletRole>();
        }

        public void Save()
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.InsertOrReplaceWithChildren(this, recursive: true);
            }
        }

        public void Delete()
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.Delete(this);
            }
        }

        public string Fullname
        {
            get
            {
                return Firstname + ' ' + Lastname;
            }
        }

        public bool CreateUser()
        {
            int rowsInserted;

            TabletUser user = new TabletUser() {
                Username = this.Username,
                Password = this.Password,
                Firstname = this.Firstname,
                Lastname = this.Lastname,
                Enabled = this.Enabled,
                AccountActivated = this.AccountActivated,
                ClientUpdated = DateTime.Now
            };

            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<TabletUser>();
                rowsInserted = conn.Insert(user);
            }
            if (rowsInserted > 0) return true;
            else return false;
        }

        public bool ToggleAccountEnabled()
        {
            Enabled = !Enabled;
            return Enabled;
        }

        public bool ToggleAccountActivation()
        {
            AccountActivated = !AccountActivated;
            return AccountActivated;
        }

        public static TabletUser AuthenticateUser(string username, string password)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
                {
                    TabletUser user = conn.Get<TabletUser>(username.ToLower());
                    if (user.Username.ToLower().Equals(username) && user.Password.Equals(password))
                        return user;
                }
            }
            catch (Exception)
            {
                return null;
            }
            return null;   
        }

       
    }


}
