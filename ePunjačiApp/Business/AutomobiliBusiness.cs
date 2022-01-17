using ePunjačiData;
using Shered.BiznisInterfejsi;
using Shered.Interfejsi;
using Shered.Modeli;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class AutomobiliBusiness : IAutomobiliBusiness
    {
        private readonly IAutomobiliRepository automobiliRepository;
        public AutomobiliBusiness()
        {
            automobiliRepository = new AutomobiliRepository();
        }
        public bool DodajAutomobil(Automobil automobil)

            => automobiliRepository.DodajAutomobil(automobil);

        public bool IzmeniAutomobil(Automobil automobil)

            => automobiliRepository.IzmeniAutomobil(automobil);

        public bool ObrišiAutomobil(Automobil automobil)

            => automobiliRepository.ObrišiAutomobil(automobil);

        public List<Automobil> SviAutomobili()

            => automobiliRepository.SviAutomobili();
    }
}
