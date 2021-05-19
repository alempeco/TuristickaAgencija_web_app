using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickaAgencija.EntityModels
{
    public class Obavijesti
    {
        [Key]
        public int ObavijestiId { get; set; }
        public string Naziv { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime Datum { get; set; }
        public byte[] Slika { get; set; }
    }
}
