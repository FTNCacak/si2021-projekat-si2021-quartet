using Shered.Modeli;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shered.Interfejsi
{
    public interface IKorisniciRepository
    {
        List<Korisnik> SviKorisnici();
        bool DodajKorisnik(Korisnik korisnik);
        bool IzmeniKorisnik(Korisnik korisnik);
        bool ObrišiKorisnik(string jmbg);
    }
}
