using Shered.Modeli;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shered.Interfejsi
{
    public interface IPriključciRepositrty
    {
        List<Priključak> SviPriključci();
        bool DodajPriključak(Priključak priključak);
        bool IzmeniPriključak(Priključak priključak);
        bool ObrišiPriključak(Priključak priključak);
    }
}
