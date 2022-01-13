using ePunjačiData;
using Shered.BiznisInterfejsi;
using Shered.Interfejsi;
using Shered.Modeli;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class KorisniciBusiness : IKorisniciBusiness
    {
        private readonly IKorisniciRepository koriniciRepository;
        public KorisniciBusiness()
        {
            koriniciRepository = new KorisniciRepository();
        }
        public bool DodajKorisnik(Korisnik korisnik)

            => koriniciRepository.DodajKorisnik(korisnik);

        public bool IzmeniKorisnik(Korisnik korisnik)

            => koriniciRepository.IzmeniKorisnik(korisnik);

        public bool ObrišiKorisnik(string jmbg)

            => koriniciRepository.ObrišiKorisnik(jmbg);

        public List<Korisnik> SviKorisnici()

            => koriniciRepository.SviKorisnici();
    }
}
