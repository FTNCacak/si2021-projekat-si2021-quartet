using System;
using System.Collections.Generic;
using System.Text;

namespace Shered.Modeli
{
    public class Automobil
    {
        public string Broj_šasije { get; set; }
        public string Id_priključka { get; set; }
        public int JMBG_korisnika { get; set; }
        public string Marka { get; set; }
        public string Tip { get; set; }
        public int Kapacitet_baterije { get; set; }
        public List<Priključak> ListPriključci { get; set; } = new List<Priključak>();
        public List<Korisnik> ListKorisnici { get; set; } = new List<Korisnik>();
    }
}
