using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ÜritusedWebApplication.Models.Uritused
{
    public class UrituseLisamineModel
    {
        public string Uritusenimi { get; set; }
        public DateTime Toimumisaeg { get; set; }
        public string Koht { get; set; }
        public string Lisainfo { get; set; }
    }
}
