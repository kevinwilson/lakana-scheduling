using System;
using SQLite;
using System.Collections.Generic;
using SQLiteNetExtensions.Attributes;
using System.Linq;

namespace LakanaScheduling.Models
{
    public class TabletRole : IEquatable<TabletRole>
    {
        [PrimaryKey]
        public string Role { get; set; }
        public string RoleDescription { get; set; }
        public DateTime ServerUpdated { get; set; }
        public DateTime ClientUpdated { get; set; }

        [ManyToMany(typeof(TabletUserRole))]
        public List<TabletUser> Users { get; set; }

        public bool Equals(TabletRole comparison)
        {
            return this.Role == comparison.Role;
        }

        public TabletRole()
        {
        }

        public bool CreateRole()
        {
            int rowsInserted;

            TabletRole role = new TabletRole()
            {
                Role = this.Role,
                RoleDescription = this.Role,
                ClientUpdated = DateTime.Now
            };

            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<TabletRole>();
                rowsInserted = conn.Insert(role);
            }
            if (rowsInserted > 0) return true;
            else return false;
        }

        public static List<TabletRole> GetTabletRoles()
        {
             using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<TabletRole>();
                List<TabletRole> tabletRoles = conn.Table<TabletRole>().ToList();
                return tabletRoles;
            }

        }

        public override string ToString()
        {
            return Role;
        }
    }
   
}