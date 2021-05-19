//using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickaAgencija.ViewModel
{
    public class PutovanjaPrikaziVM
    {
        public int PutovanjaId { get; set; }
        public string NazivPutovanja { get; set; }
        public string OpisPutovanja { get; set; }
        public float CijenaPutovanja { get; set; }
        public string DatumPolaska { get; set; }
        public string DatumDolaska { get; set; }
        public int BrojPutnika { get; set; }
        public string PopisPutnika { get; set; }
        //public string Klijent { get; set; }
        public string Prevoz { get; set; }
        public string Smjestaj { get; set; }
     


    }
}
