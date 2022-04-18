using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ÜritusedWebApplication.Models.Uritused
{
    public class EttevoteDetailModel
    {
        public int UID { get; set; }
        public int ID { get; set; }
        public string EttevotteNimi { get; set; }
        public long EttevõtteRegistrikood { get; set; }
        public int OsalejateArv { get; set; }
        public int Makseviis { get; set; }
        public string Lisainfo { get; set; }
    }
}
