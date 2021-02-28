using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHelper.Items
{
    public class Sala
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string nome { get; set; }
        public int lotacao { get; set; }
    }
}
