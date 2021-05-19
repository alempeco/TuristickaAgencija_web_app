using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickaAgencija.ViewModel
{
    public class ZaposlenikUrediVM
    {
        public int ZaposlenikId { get; set; }
        public string StrucnaSprema { get; set; }
        [Required(ErrorMessage = "Odaberite korisnika!")]

        public int KorisnikId { get; set; }
        public List<SelectListItem> korisnici { get; set; }
    }
}
