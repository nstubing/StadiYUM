using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SQLAppStadi.Model
{
    class ConcessionItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public int ConcessionId { get; set; }

        public int ItemId { get; set; }
    }
}
