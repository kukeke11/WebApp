using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace UritusedData.Models
{
    //Mudel mille põhjal luuakse andmebaas initiate_migration "PLACEHOLDER" abiga
    public class Osalejad
    {
        public int ID { get; set; }
        [Required]
        public string Eesnimi { get; set; }
        [Required]
        public string Perenimi { get; set; }
        [Required]
        public long Isikukood { get; set; }
        [Required]
        [Range(1,2)]
        public int Makseviis { get; set; }
        public string Lisainfo { get; set; }

    }
}
