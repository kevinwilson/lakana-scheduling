using System;
using SQLite;
using System.ComponentModel;

namespace LakanaScheduling.Models
{
    public class User 
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
