using Shered.Interfejsi;
using Shered.Modeli;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ePunjačiData
{
    class KorisniciRepository : IKorisniciRepository
    {
        public List<Korisnik> SviKorisnici()
        {
            List<Korisnik> listaKorisnici = new List<Korisnik>();

            using (SqlCommand sqlCommand = BaseConnection.GetSqlCommand("select * from korisnici"))
            {

                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Korisnik korisnik = new Korisnik
                        {
                            JMBG = dataReader.GetInt32(0),
                            Ime = dataReader.GetString(1),
                            Prezime = dataReader.GetString(2),
                            Broj_telefona = dataReader.GetString(3),
                            Email = dataReader.GetString(4)
                        };
                        listaKorisnici.Add(korisnik);
                    }
                }
            }

            return listaKorisnici;
        }
        public bool DodajKorisnik(Korisnik korisnik)
        {
            string query = string.Format($"insert into korisnici(JMBG, Ime, Prezime, Broj_telefona, Email) values('{korisnik.JMBG}', '{korisnik.Ime}', '{korisnik.Prezime}', '{korisnik.Broj_telefona}', '{korisnik.Email}')");
            return BaseConnection.ExecuteNonQuerySqlCommand(query);
        }
        public bool IzmeniKorisnik(Korisnik korisnik)
        {
            string query = string.Format($"update korisnici set Ime = '{korisnik.Ime}', Prezime = '{korisnik.Prezime}', Broj_telefona = '{korisnik.Broj_telefona}', Email = '{korisnik.Email}' where JMBG = '{korisnik.JMBG}'");
            return BaseConnection.ExecuteNonQuerySqlCommand(query);
        }
        public bool ObrišiKorisnik(string jmbg)
        => BaseConnection.ExecuteNonQuerySqlCommand($"delete from korisnici where JMBG= {jmbg}");

    }
}
