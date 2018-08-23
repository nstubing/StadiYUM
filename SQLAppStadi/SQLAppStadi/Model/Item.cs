using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SQLAppStadi.Model
{
    class Item
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string ItemName { get; set; }

        public double Price { get; set; }

        public string Image { get; set; }
    }
}
