using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHelper.Items
{
    public class Participante
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Sala1 { get; set; }
        public string Sala2 { get; set; }
        public string SalaCafe { get; set; }

    }
}
