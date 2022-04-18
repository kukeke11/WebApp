using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UritusedData.Models;

namespace ÜritusedWebApplication.Models.Uritused
{
    public class UritusedListingModel
    {
        public int Id { get; set; }
        public string Uritusenimi { get; set; }
        public string Toimumisaeg { get; set; }
        public string Koht { get; set; }
        public string Lisainfo { get; set; }
        public List<Osalejad> Osalejad { get; set; }
        public List<Ettevote> Ettevotted { get; set; }
        public int toimus { get; set; }

        public class UrituseOsalejadModel
        {
            public int ID { get; set; }
            public string Eesnimi { get; set; }
            public string Perenimi { get; set; }
            public long Isikukood { get; set; }
            public int Makseviis { get; set; }
            public string Lisainfo { get; set; }
        }
        public class UrituseEttevottedModel
        {
            public int ID { get; set; }
            public string EttevotteNimi { get; set; }
            public long EttevõtteRegistrikood { get; set; }
            public int OsalejateArv { get; set; }
            public int Makseviis { get; set; }
            public string Lisainfo { get; set; }
        }
    }
}
