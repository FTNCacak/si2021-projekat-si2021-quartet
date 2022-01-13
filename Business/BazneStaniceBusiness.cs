using ePunjačiData;
using Shered.BiznisInterfejsi;
using Shered.Modeli;
using System;
using System.Collections.Generic;

namespace Business
{
    public class BazneStaniceBusiness : IBazneStaniceBusiness
    {
        private readonly BazneStaniceRepository bazneStaniceRepository;
        public BazneStaniceBusiness()
            {
                bazneStaniceRepository = new BazneStaniceRepository(); 
            } 
        public bool DodajBaznaStanica(BaznaStanica bs)
        {
            return bazneStaniceRepository.DodajBaznaStanica(bs);
        }

        public bool IzmeniBaznaStanica(BaznaStanica bs)
        {
            return bazneStaniceRepository.IzmeniBaznaStanica(bs);
        }

        public bool ObrišiBaznaStanica(string id_stanice)
        {
            return bazneStaniceRepository.ObrišiBaznaStanica(id_stanice);
        }

        public List<BaznaStanica> SveBazneStanice()

            => bazneStaniceRepository.SveBazneStanice();
         
    }
}
