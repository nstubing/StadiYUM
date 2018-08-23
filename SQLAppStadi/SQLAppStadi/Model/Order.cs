using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SQLAppStadi.Model
{
    class Order
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }


        public int UserId { get; set; }

        public int ItemId { get; set; }

        public int ConcessionId { get; set; }

        public int Completed { get; set; }
    }
}
