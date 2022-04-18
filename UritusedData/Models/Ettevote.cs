using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UritusedData.Models
{
    public class Ettevote
    {
        public int ID { get; set; }
        [Required]
        public string EttevõtteNimi { get; set; }
        [Required]
        public long EttevõtteRegistrikood { get; set; }
        [Required]
        public int OsalejateArv { get; set; }
        [Required]
        [Range(1, 2)]
        public int Makseviis { get; set; }
        public string Lisainfo { get; set; }
    }
}
