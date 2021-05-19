using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickaAgencija.ViewModel
{
    public class PutniciKorisniciUrediVM
    {
        public int PutnikKorisnikID { get; set; }
        [Required(ErrorMessage = "Odaberite korisnika!")]

        public int KorisnikID { get; set; }
        [Required(ErrorMessage = "Odaberite korisnika!")]

        public List<SelectListItem> korisnici { get; set; }
    }
}
