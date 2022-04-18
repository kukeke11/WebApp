using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace UritusedData.Models
{
    //Mudel mille põhjal luuakse andmebaas initiate_migration "PLACEHOLDER" abiga
    public class Uritused
    {
        public int Id { get; set; }
        [Required]
        public string Uritusenimi { get; set; }
        [Required]
        public DateTime Toimumisaeg { get; set; }
        [Required]
        public string Koht { get; set; }
        public string Lisainfo { get; set; }
        public List<Osalejad> Osalejad { get; set; }
        public List<Ettevote> Ettevotted{ get; set; }
    }
}
