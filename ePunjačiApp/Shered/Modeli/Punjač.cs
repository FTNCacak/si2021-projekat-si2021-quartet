using System;
using System.Collections.Generic;
using System.Text;

namespace Shered.Modeli
{
    public class Punjač
    {
        public string Id_punj { get; set; }
        public int Snaga { get; set; }
        public string Id_bazne_stanice { get; set; }
        public List<BaznaStanica> ListBazneStanice { get; set; } = new List<BaznaStanica>();
}
}
