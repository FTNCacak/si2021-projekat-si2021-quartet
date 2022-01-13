using Shered.Modeli;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shered.BiznisInterfejsi
{
    public interface IKorisniciBusiness
    {
        List<Korisnik> SviKorisnici();
        bool DodajKorisnik(Korisnik korisnik);
        bool IzmeniKorisnik(Korisnik korisnik);
        bool ObrišiKorisnik(string jmbg);
    }
}
