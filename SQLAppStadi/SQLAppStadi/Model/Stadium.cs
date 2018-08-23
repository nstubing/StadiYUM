using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SQLAppStadi.Model
{
    class Stadium
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string StadiumName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int Zipcode { get; set; }

        public string Image { get; set; }
    }
}
