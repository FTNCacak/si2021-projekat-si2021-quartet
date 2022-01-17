using ePunjačiData;
using Shered.BiznisInterfejsi;
using Shered.Interfejsi;
using Shered.Modeli;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class PriključciBusiness : IPriključciBusiness
    {
        private readonly IPriključciRepository priključciRepositrty;
        public PriključciBusiness()
        {
            priključciRepositrty = new PriključciRepository();
        }
        public bool DodajPriključak(Priključak priključak)

            => priključciRepositrty.DodajPriključak(priključak);

        public bool IzmeniPriključak(Priključak priključak)
        => priključciRepositrty.IzmeniPriključak(priključak);

        public bool ObrišiPriključak(Priključak priključak)

            => priključciRepositrty.ObrišiPriključak(priključak);

        public List<Priključak> SviPriključci()

            => priključciRepositrty.SviPriključci();
    }
}
