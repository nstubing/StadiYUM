using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace SQLAppStadi.Model
{
    public class Concession
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Section { get; set; }
        [OneToMany]
        public List<Item> Items { get; set; }
    }
}
