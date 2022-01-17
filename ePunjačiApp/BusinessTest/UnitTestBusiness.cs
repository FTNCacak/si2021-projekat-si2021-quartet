using Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shered.BiznisInterfejsi;
using Shered.Modeli;

namespace BusinessTest
{
    [TestClass]
    public class UnitTestBusiness
    {
        private IKorisniciBusiness korisnikBusiness = new KorisniciBusiness();
        [TestMethod]
        [Priority(0)]
        public void IsKorisnikInerted()
        {
            Korisnik korisnik = new Korisnik
            {
                JMBG = 12011965287820,
                Ime = "Test A",
                Prezime = "Test P",
                Broj_telefona = "+38166875213",
                Email = "testtest@gmail.com"
            };
            var result = korisnikBusiness.DodajKorisnik(korisnik);
            Assert.IsTrue(result);
        }
        [TestMethod]
        [Priority(1)]
        public void IsKorisnikRemoved()
        {
            long jmbg = 12011965287820;
            var result = korisnikBusiness.ObrišiKorisnik(long.Parse(jmbg.ToString()));

            Assert.IsTrue(result);
        }
        private IBazneStaniceBusiness bazneStaniceBusiness = new BazneStaniceBusiness();
        [TestMethod]
        [Priority(2)]
        public void BazneStaniceInserted()
        {
            BaznaStanica baznaStanica = new BaznaStanica
            {
                Id_stanice = "BS006",
                Naziv = "Erdeč",
                Adresa = "Milana Babića"
            };

            var result = bazneStaniceBusiness.DodajBaznaStanica(baznaStanica);


            Assert.IsTrue(result);
        }


        [TestMethod]
        [Priority(3)]
        public void IsBazneStaniceRemoved()
        {


            var result = bazneStaniceBusiness.ObrišiBaznaStanica("BS006");

            Assert.IsTrue(result);
        }
    }   
}
