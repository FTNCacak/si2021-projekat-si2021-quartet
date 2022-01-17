using Shered.Interfejsi;
using Shered.Modeli;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ePunjačiData
{

    public class PriključciRepository : IPriključciRepository
    {
        public List<Priključak> SviPriključci()
        {
            List<Priključak> listaPriključaka = new List<Priključak>();
            string query = $"select pr.*, p.* from priključci pr join punjači p on pr.Id_punjača=p.Id_punj";
            using (SqlCommand sqlCommand = BaseConnection.GetSqlCommand(query))
            {
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Punjač punjač = new Punjač();
                        Priključak priključak = new Priključak();
                        priključak.Id_prik = dataReader.GetString(0);
                        priključak.Indikator = dataReader.GetBoolean(dataReader.GetOrdinal("Indikator"));
                        priključak.Id_punjača = dataReader.GetString(1);
                        punjač.Id_punj = dataReader.GetString(3);
                        punjač.Snaga = dataReader.GetInt32(5);
                        punjač.Id_bazne_stanice = dataReader.GetString(4);
                        priključak.ListPunjač.Add(punjač);
                        listaPriključaka.Add(priključak);
                    }
                }
            }

            return listaPriključaka;
        }
        public bool DodajPriključak(Priključak priključak)
        {
            string query = string.Format($"insert into priključci(Id_prik, Indikator, Id_punjača) values('{priključak.Id_prik}', '{priključak.Indikator}', '{priključak.Id_punjača}')");
            return BaseConnection.ExecuteNonQuerySqlCommand(query);
        }
        public bool IzmeniPriključak(Priključak priključak)
        {
            string query = string.Format($"update priključci set Indikator = '{priključak.Indikator}', Id_punjača = '{priključak.Id_punjača}' where Id_prik = '{priključak.Id_prik}'");
            return BaseConnection.ExecuteNonQuerySqlCommand(query);
        }

        public bool ObrišiPriključak(Priključak priključak)
        {
            string query = $"delete from priključci where Id_prik = '{priključak.Id_prik}' and Id_punjača = '{priključak.Id_punjača}'";
            return BaseConnection.ExecuteNonQuerySqlCommand(query);
        }
    }
}
