using Shered.Interfejsi;
using Shered.Modeli;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ePujiačiData
{
    class PunjačiRepository : IPunjačiRepository
    { 
        public List<Punjač> SviPunjači()
        {
            List<Punjač> listaPunjača = new List<Punjač>();

        string query = $"select p.*, b.* form punjači p join bazne_stanice b on p.Id_bazne_stanice=b.Id_stanice";
        using (SqlCommand sqlCommand = BaseConnection.GetSqlCommand(query))
        {

                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                if(dataReader.HasRows)
                {                     
                    while (dataReader.Read())
                    {
                        BaznaStanica bs = new BaznaStanica();
                        Punjač punjač = new Punjač();
                        punjač.Id_punj= dataReader.GetString(0);
                        punjač.Snaga = dataReader.GetInt32(1);
                        punjač.Id_bazne_stanice = dataReader.GetString(2);
                        bs.Id_stanice = dataReader.GetString(3);
                        bs.Naziv = dataReader.GetString(4);
                        bs.Adresa = dataReader.GetString(5);
                        punjač.ListBazneStanice.Add(bs);
                        listaPunjača.Add(punjač);
                    }
                }
        }

        return listaPunjača;
        }
        public bool DodajPunjač(Punjač punjač)
        {
        string query = string.Format($"insert into punjči(Id_punj, Snaga, Id_bazne_stanice) values('{punjač.Id_punj}', '{punjač.Snaga}', '{punjač.Id_bazne_stanice}')");
        return BaseConnection.ExecuteNonQuerySqlCommand(query);
        }
        public bool IzmeniPunjač(Punjač punjač)
        {
            string query = string.Format($"update punjači set Snaga = '{punjač.Snaga}', Id_bazne_stanice = '{punjač.Id_bazne_stanice}' where Id_punj = '{punjač.Id_punj}'");
            return BaseConnection.ExecuteNonQuerySqlCommand(query);
         }

        public bool ObrišiPunjač(Punjač punjač)
        {
            string query = $"delete from punjači where Id_punj = '{punjač.Id_punj}' and Id_bazne_stanice = '{punjač.Id_bazne_stanice}'";
            return BaseConnection.ExecuteNonQuerySqlCommand(query);
        }
    }
}
