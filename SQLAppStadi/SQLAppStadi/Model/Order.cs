using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace SQLAppStadi.Model
{
    public class Order
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [ForeignKey(typeof(RealUser))]
        public int UserId { get; set; }

        public int ItemId { get; set; }

        public int ConcessionId { get; set; }

        public int Completed { get; set; }
    }
}
