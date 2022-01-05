using Shered.Interfejsi;
using Shered.Modeli;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePujiačiData
{
    public class BazneStaniceRepository : IBazneStaniceRepository
    {

        public List<BaznaStanica> SveBazneStanice()
        {
            List<BaznaStanica> listaBS = new List<BaznaStanica>();

            using (SqlCommand sqlCommand = BaseConnection.GetSqlCommand("select * from bazne_stanice")) 
            { 

                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        BaznaStanica bs = new BaznaStanica();
                        bs.Id_stanice = dataReader.GetString(0);
                        bs.Naziv = dataReader.GetString(1);
                        bs.Adresa = dataReader.GetString(2);

                        listaBS.Add(bs);
                    }
                }
            }

            return listaBS;
        }
        public bool DodajBaznaStanica(BaznaStanica bs)
        {
                string query = string.Format($"insert into bazne_stanice(Id_stanice, Naziv, Adresa) values('{bs.Id_stanice}', '{bs.Naziv}', '{bs.Adresa}')");
            return BaseConnection.ExecuteNonQuerySqlCommand(query);
        }
        public bool IzmeniBaznaStanica(BaznaStanica bs)
        {
            string query = string.Format($"update bazne_stanice set Naziv = '{bs.Naziv}', Adresa = '{bs.Adresa}' where Id_stanice = '{bs.Id_stanice}'");
            return BaseConnection.ExecuteNonQuerySqlCommand(query);
        }
    public bool ObrišiBaznaStanica(string id_stanice)
    => BaseConnection.ExecuteNonQuerySqlCommand($"delete from bazne_stanice Id_stanice = {id_stanice}");
    }
}