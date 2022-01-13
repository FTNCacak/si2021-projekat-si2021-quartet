using Shered.Modeli;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shered.BiznisInterfejsi
{
    public interface IPunjačiBusiness
    {
        List<Punjač> SviPunjači();
        bool DodajPunjač(Punjač punjač);
        bool IzmeniPunjač(Punjač punjač);
        bool ObrišiPunjač(Punjač punjač);
    }
}
