using Shered.BiznisInterfejsi;
using ePunjačiData;
using Shered.Interfejsi;
using Shered.Modeli;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class PunjačiBusiness : IPunjačiBusiness

    {
        // private readonly BazneStaniceRepository bazneStaniceRepository;
        // private readonly IPriključciRepository priključciRepositrty;
        
        private readonly IPunjačiRepository punjačiRepository;
        public PunjačiBusiness()
        {
            punjačiRepository = new PunjačiRepository();
            // priključciRepositrty = new PriključciRepository();
            // bazneStaniceRepository = new BazneStaniceRepository();
        }
        public bool DodajPunjač(Punjač punjač)

            => punjačiRepository.DodajPunjač(punjač);

        public bool IzmeniPunjač(Punjač punjač)

            => punjačiRepository.IzmeniPunjač(punjač);

        public bool ObrišiPunjač(Punjač punjač)

            => punjačiRepository.ObrišiPunjač(punjač);

        public List<Punjač> SviPunjači()

            => punjačiRepository.SviPunjači();

        //  Uraditi u prezentacionom sloju
        /*public List<Punjač> DostupniPunjači()
        {
            List<Punjač> punjač = new List<Punjač>();
            foreach (var item in priključciRepositrty.SviPriključci())
                if (item.Indikator)
                {
                    foreach (var item2 in item.ListPunjač)
                    {
                        foreach (var item3 in item2.ListBazneStanice)
                        {
                            if (item.Id_punjača == item2.Id_punj && item2.Id_bazne_stanice == item3.Id_stanice)
                                punjač = item.ListPunjač;
                            string uslov = item.Indikator ? "Zauzet" : "Dostupan";
                        }
                    }
                }
            return punjač;
        }*/
    }
}
