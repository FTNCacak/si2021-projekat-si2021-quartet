using Shered.Interfejsi;
using Shered.Modeli;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ePujiačiData
{
    class AutomobiliRepository : IAutomobiliRepository
    {
        public List<Automobil> SviAutomobili()
        {
            List<Automobil> listaAutomobila = new List<Automobil>();

            string query = $"select a.* k.*, pr.* form automobili a inner join korisnici k on  k.JMBG = a.JMBG_korisnika inner join priključci pr on pr.Id_prik = a.Id_priključka";
            using (SqlCommand sqlCommand = BaseConnection.GetSqlCommand(query))
            {

                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Automobil automobil = new Automobil();
                        Korisnik korisnik = new Korisnik();
                        Priključak priključak = new Priključak();
                        automobil.Broj_šasije = dataReader.GetString(0);
                        automobil.Id_priključka = dataReader.GetString(1);
                        automobil.JMBG_korisnika = dataReader.GetInt32(2);
                        automobil.Marka = dataReader.GetString(3);
                        automobil.Tip = dataReader.GetString(4);
                        automobil.Kapacitet_baterije = dataReader.GetInt32(5);
                        korisnik.JMBG = dataReader.GetInt32(6);
                        korisnik.Ime = dataReader.GetString(7);
                        korisnik.Prezime = dataReader.GetString(8);
                        korisnik.Broj_telefona = dataReader.GetString(9);
                        korisnik.Email = dataReader.GetString(10);
                        priključak.Id_prik = dataReader.GetString(11);
                        priključak.Indikator = dataReader.GetBoolean(12);
                        priključak.Id_punjača = dataReader.GetString(13);
                        automobil.ListPriključci.Add(priključak);
                        automobil.ListKorisnici.Add(korisnik);
                        listaAutomobila.Add(automobil);
                    }
                }
            }

            return listaAutomobila;
        }
        public bool DodajAutomobil(Automobil automobil)
        {
            string query = string.Format($"insert into automobili(Broj_šasije, Id_priključka, JMBG_korisnika, Marka, Tip, Kapacitet_baterije) values('{automobil.Broj_šasije}', '{automobil.Id_priključka}', '{automobil.JMBG_korisnika}', '{automobil.Marka}'), '{automobil.Tip}', '{automobil.Kapacitet_baterije}'");
            return BaseConnection.ExecuteNonQuerySqlCommand(query);
        }
        public bool IzmeniAutomobil(Automobil automobil)
        {
            string query = string.Format($"update automobili set Mark = '{automobil.Marka}', Tip = '{automobil.Tip}' Kapacitet_baterije = '{automobil.Kapacitet_baterije}' where Broj_Šasije = '{automobil.Broj_šasije}' and Id_priključka = '{automobil.Id_priključka}' and JMBG_korisnika = '{automobil.JMBG_korisnika}'");
            return BaseConnection.ExecuteNonQuerySqlCommand(query);
        }

        public bool ObrišiAutomobil(Automobil automobil)
        {
            string query = $"delete from automobili where Broj_Šasije = '{automobil.Broj_šasije}' and Id_priključka = '{automobil.Id_priključka}' and JMBG_korisnika = '{automobil.JMBG_korisnika}'";
            return BaseConnection.ExecuteNonQuerySqlCommand(query);
        }
    }
}
