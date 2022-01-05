using System;
using System.Collections.Generic;
using System.Text;

namespace Shered.Modeli
{
    public class Priključak
    {
        public string Id_prik { get; set; }
        public bool Indikator { get; set; }
        public string Id_punjača { get; set; }
        public List<Punjač> ListPunjač { get; set; } = new List<Punjač>();
    }
}
