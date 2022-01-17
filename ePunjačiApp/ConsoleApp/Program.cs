using Business;
using Shered.BiznisInterfejsi;
using Shered.Modeli;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IBazneStaniceBusiness bazneStaniceBusiness1 = new BazneStaniceBusiness();
            /*Console.WriteLine("-----------------------Unos Bazne Stanice------------------------ ");
            
                        BaznaStanica baznaStanica = new BaznaStanica
                        {
                            Id_stanice = "BS006",
                            Naziv = "Big Fashion 6",
                            Adresa = "Kraljice Marije 56"
                        };
                        if (bazneStaniceBusiness1.DodajBaznaStanica(baznaStanica))
                        {
                            Console.WriteLine("Uspesan upis podataka u bazu");
                        }
                        else
                        {
                            Console.WriteLine("Greska");
                        }*/
            Console.WriteLine("-------------------------------- Ispis BS ---------------------------");
            foreach (var item in bazneStaniceBusiness1.SveBazneStanice())
            {
                Console.WriteLine(item.Id_stanice + " " + item.Naziv + " " + item.Adresa);
            }

            IPunjačiBusiness punjačiBusiness = new PunjačiBusiness();
            /*Console.WriteLine("-----------------------Unos Punjača------------------------ ");
            Punjač punjač = new Punjač
            {
                Id_punj = "CH002",
                Snaga = 400,
                Id_bazne_stanice = "BS002"
            };
            if (punjačiBusiness.DodajPunjač(punjač))
            {
                Console.WriteLine("Uspesan upis podataka u bazu");
            }
            else
            {
                Console.WriteLine("Greska");
            }*/

            Console.WriteLine("-----------------------Ispis Punjaci------------------------ ");
            foreach (var item in punjačiBusiness.SviPunjači())
            {
                foreach (var item2 in item.ListBazneStanice)
                {
                    if (item.Id_bazne_stanice == item2.Id_stanice)
                    {
                        Console.WriteLine(item.Id_punj + " " + item.Snaga + " " + item.Id_bazne_stanice);
                    }
                }
            }

            IPriključciBusiness priključciBusiness = new PriključciBusiness();
            /*Console.WriteLine("-----------------------Unos Priključci------------------------ ");
            Priključak priključak = new Priključak
            {
                Id_prik = "PL003",
                Id_punjača = "CH002",
                Indikator = true
            };
            if (priključciBusiness.DodajPriključak(priključak))
            {
                Console.WriteLine("Uspesno daodat");
            }
            else
            {
                Console.WriteLine("Greska");
            }*/
            Console.WriteLine("-----------------------Ispis Priključci------------------------ ");
            foreach(var item in priključciBusiness.SviPriključci())
            {
                foreach(var item2 in item.ListPunjač)
                {
                    if(item .Id_punjača == item2.Id_punj)
                    {
                        string uslov = item.Indikator ? "Nedostupan" : "Dostupan";
                        Console.WriteLine(item.Id_prik + " " + item.Id_punjača + " " + uslov + " " + item2.Snaga);
                    }
                }
            }
            IKorisniciBusiness korisniciBusiness = new KorisniciBusiness();
           /* Console.WriteLine("----------------------------------Unos Korisnika-----------------------------------");
            Korisnik korisnik = new Korisnik
            {
                JMBG = 2801988782828,
                Ime = "Borko",
                Prezime = "Lao",
                Broj_telefona = "+381632651678",
                Email = "borla@gmail.com"
            };
            if (korisniciBusiness.DodajKorisnik(korisnik))
            {
                Console.WriteLine("Uspesno daodat");
            }
            else
            {
                Console.WriteLine("Greska");
            }*/
            Console.WriteLine("-----------------------------------------Ispis Korisnika------------------------------------");
            foreach(var item in korisniciBusiness.SviKorisnici())
            {
                Console.WriteLine(item.Ime + " " + item.Prezime + " " + item.JMBG);
            }
            IAutomobiliBusiness automobiliBusiness = new AutomobiliBusiness();
           /* Console.WriteLine("-----------------------------------------Unos Automobila------------------------------------");
            Automobil automobil = new Automobil
            {
                Broj_šasije = "OYO5458A832T",
                Id_priključka = "PL003",
                JMBG_korisnika = 2608921752818,
                Marka = "Toyota",
                Tip = "GZ",
                Kapacitet_baterije = 90
            };
            if (automobiliBusiness.DodajAutomobil(automobil))
            {
                Console.WriteLine("Uspesno daodat");
            }
            else
            {
                Console.WriteLine("Greska");
            }*/
            Console.WriteLine("-----------------------------------------Ispis Automobila------------------------------------");
            foreach (var item in automobiliBusiness.SviAutomobili())
            {
                foreach (var item2 in item.ListKorisnici)
                {
                    foreach (var item3 in item.ListPriključci)
                    {
                        if (item.JMBG_korisnika == item2.JMBG && item.Id_priključka == item3.Id_prik)
                        {
                            string uslov = item3.Indikator ? "Nedostupan" : "Dostupan";
                            Console.WriteLine(item.Broj_šasije + " " + item.Marka + " " + item.Tip + " " + item.Kapacitet_baterije + " " + item2.Ime + " " + item2.Prezime + " " + item2.Email + " " + uslov);
                        }
                    }
                }
            }
        }
    }
}
