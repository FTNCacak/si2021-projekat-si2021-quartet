using Shered.Modeli;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shered.BiznisInterfejsi
{
    public interface IAutomobiliBusiness
    {
        List<Automobil> SviAutomobili();
        bool DodajAutomobil(Automobil automobil);
        public bool IzmeniAutomobil(Automobil automobil);
        bool ObrišiAutomobil(Automobil automobil);
    }
}
