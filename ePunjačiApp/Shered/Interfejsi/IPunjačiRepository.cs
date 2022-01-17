using Shered.Modeli;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shered.Interfejsi
{
    public interface IPunjačiRepository
    {
        List<Punjač> SviPunjači();
        bool DodajPunjač(Punjač punjač);
        bool IzmeniPunjač(Punjač punjač);
        bool ObrišiPunjač(Punjač punjač);
    }
}
