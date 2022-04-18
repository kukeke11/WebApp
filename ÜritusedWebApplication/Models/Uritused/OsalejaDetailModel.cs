using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ÜritusedWebApplication.Models.Uritused
{
    public class OsalejaDetailModel
    {
        public int UID { get; set; }
        public int ID { get; set; }
        public string Eesnimi { get; set; }
        public string Perenimi { get; set; }
        public long Isikukood { get; set; }
        public int Makseviis { get; set; }
        public string Lisainfo { get; set; }
    }
}
