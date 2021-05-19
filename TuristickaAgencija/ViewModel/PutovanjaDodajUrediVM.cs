using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickaAgencija.ViewModel
{
    public class PutovanjaDodajUrediVM
    {
        public int PutovanjaId { get; set; }

        [Required(ErrorMessage = "Unesite naziv putovanja!")]
        public string NazivPutovanja { get; set; }
        [Required(ErrorMessage = "Unesite opis putovanja!")]

        public string OpisPutovanja { get; set; }
        [Required(ErrorMessage = "Unesite cijenu putovanja!")]

        public float CijenaPutovanja { get; set; }
        [Required(ErrorMessage = "Unesite datum polaska!")]

        public DateTime DatumPolaska { get; set; }
        [Required(ErrorMessage = "Unesite datum dolaska!")]

        public DateTime DatumDolaska { get; set; }
        [Required(ErrorMessage = "Unesite cijenu putovanja!")]

        public int BrojPutnika { get; set; }
        public string PopisPutnika { get; set; }

        //public int KlijentId { get; set; }

        //public List<SelectListItem> Klijent { get; set; }
        public int? PrevozId { get; set; }

        public List<SelectListItem> Prevoz { get; set; }
        public int? SmjestajId { get; set; }

        public List<SelectListItem> Smjestaj { get; set; }
        public IFormFile Dodatak { get; set; }
    }
}
