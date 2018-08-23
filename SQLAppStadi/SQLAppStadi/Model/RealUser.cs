using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SQLAppStadi.Model
{
    public class RealUser
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int CurrentSection { get; set; }
        public int Seat { get; set; }
    }
}
