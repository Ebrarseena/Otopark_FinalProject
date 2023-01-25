using bil203_Otopark_FinalProject.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bil203_Otopark_FinalProject.BusinessLayer
{
    public class BusinessCodes : IBusinessCodes
    {
        public int AktifAracSayisiGetir()
        {
            DataIslem veritabani = new DataIslem();
            SqlConnection connection = veritabani.OpenConnection();
            SqlCommand sqlCommand = veritabani.CreateConnection("SELECT COUNT(icerdemi) as icerdemi FROM AraclarTable where icerdemi =1;");
            SqlDataReader dataReader = sqlCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            var sonuc = 0;
            while (dataReader.Read())
            {
                sonuc = Convert.ToInt32(dataReader["icerdemi"]);
            }
            return sonuc;
        }

        public AraclarModel AracEkle(AraclarModel arac)
        {
            DataIslem veritabani = new DataIslem();
            SqlConnection connection = veritabani.OpenConnection();
            SqlCommand sqlCommand = veritabani.CreateConnection("insert into AraclarTable(marka, model, plaka, girTar,icerdemi) values(@marka, @model, @plaka, @girTar,@icerdemi)");
            sqlCommand.Parameters.Add("@marka", SqlDbType.VarChar).Value = arac.marka;
            sqlCommand.Parameters.Add("@model", SqlDbType.VarChar).Value = arac.model;
            sqlCommand.Parameters.Add("@plaka", SqlDbType.VarChar).Value = arac.plaka;
            sqlCommand.Parameters.Add("@girTar", SqlDbType.DateTime).Value = arac.girTar;
            sqlCommand.Parameters.Add("@icerdemi", SqlDbType.Int).Value = 1;
            SqlDataReader dataReader = sqlCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            return arac;
        }

        public bool AracGuncelle(AraclarModel arac)
        {
            DataIslem veritabani = new DataIslem();
            SqlConnection connection = veritabani.OpenConnection();
            SqlCommand sqlCommand = veritabani.CreateConnection("update AraclarTable set marka = '" + arac.marka.ToString() + "' ,model = '" + arac.model + "' ,plaka = '" + arac.plaka.ToString() + "' ,cikTar = '" + arac.cikTar.Value.ToString("yyyy-MM-dd HH:mm:ss")+ "' ,icerdemi = '" + arac.icerdemi.ToString() + "' where Id = '" + Form1.SetValueForText1.ToString() + "'");
            sqlCommand.Parameters.Add("@marka", SqlDbType.VarChar).Value = arac.marka;
            sqlCommand.Parameters.Add("@model", SqlDbType.VarChar).Value = arac.model;
            sqlCommand.Parameters.Add("@plaka", SqlDbType.VarChar).Value = arac.plaka;
            sqlCommand.Parameters.Add("@girTar", SqlDbType.DateTime).Value = arac.girTar;
            sqlCommand.Parameters.Add("@icerdemi", SqlDbType.Int).Value = arac.icerdemi;
            sqlCommand.Parameters.Add("@cikTar", SqlDbType.DateTime).Value = arac.cikTar.Value.ToString("yyyy-MM-dd HH:mm:ss");
            SqlDataReader dataReader = sqlCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            return true;
        }

        public List<AraclarModel> AraclariGetir()
        {
            // Bütün müşterileri bir liste içinde tutacağım
            List<AraclarModel> araclar = new List<AraclarModel>();
            DataIslem veritabani = new DataIslem();
            SqlConnection connection = veritabani.OpenConnection();
            SqlCommand sqlCommand = veritabani.CreateConnection("select Id as ID , marka as MARKA , model as MODEL , plaka as PLAKA ,icerdemi ,girTar,cikTar, (datediff(ms, dbo.AraclarTable.girTar , cikTar) / 3600000*5) as para from AraclarTable");
            SqlDataReader dataReader = sqlCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (dataReader.Read())
            {
                AraclarModel araclarmodel = new AraclarModel();

                araclarmodel.Id = Convert.ToInt32(dataReader["Id"]);
                araclarmodel.marka= dataReader["marka"].ToString();
                araclarmodel.model = dataReader["model"].ToString();
                araclarmodel.plaka = dataReader["plaka"].ToString();
                araclarmodel.icerdemi = Convert.ToInt32(dataReader["icerdemi"]);
                araclarmodel.girTar = Convert.ToDateTime(dataReader["girTar"]);

                if (dataReader["cikTar"] != null && dataReader["cikTar"] != DBNull.Value)
                {

                    araclarmodel.cikTar = Convert.ToDateTime(dataReader["cikTar"]);
                    araclarmodel.para = dataReader["para"].ToString();
                }
               
                araclar.Add(araclarmodel);
            }
            return araclar;
        }

        public bool AracSil(int id)
        {
            DataIslem veritabani = new DataIslem();
            SqlConnection connection = veritabani.OpenConnection();
            SqlCommand sqlCommand = veritabani.CreateConnection("delete from AraclarTable where Id = '" + id.ToString() + "'");
            SqlDataReader dataReader = sqlCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (dataReader.Read())
            {

            }
            AraclarModel a = new AraclarModel();
            return true;
        }

        public bool GirisYap(string username, string password)
        {
            bool isuser = false;
            DataIslem veritabani = new DataIslem();
            SqlConnection connection = veritabani.OpenConnection();
            SqlCommand sqlCommand = veritabani.CreateConnection("select * from PersonelTable where username = '" + username + "' and password= '" + password + "'");
            SqlDataReader dataReader = sqlCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (dataReader.Read())
            {          
                if (dataReader["username"] != null && dataReader["username"] != DBNull.Value)
                {
                    isuser = true;
                }
                else
                {
                    isuser = false;
                }
            }
            if (isuser)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public AraclarModel IdBilgisineGoreGetir(int id)
        {
            DataIslem veritabani = new DataIslem();
            SqlConnection connection = veritabani.OpenConnection();
            SqlCommand sqlCommand = veritabani.CreateConnection("select * from AraclarTable where Id = '" + id.ToString() + "'");
            SqlDataReader dataReader = sqlCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            AraclarModel araclarmodel = new AraclarModel();
            while (dataReader.Read())
            {
                araclarmodel.Id = Convert.ToInt32(dataReader["Id"]);
                araclarmodel.marka = dataReader["marka"].ToString();
                araclarmodel.model = dataReader["model"].ToString();
                araclarmodel.plaka = dataReader["plaka"].ToString();
                araclarmodel.icerdemi = Convert.ToInt32(dataReader["icerdemi"]);
                araclarmodel.girTar = Convert.ToDateTime(dataReader["girTar"]);
                if (dataReader["cikTar"] != null && dataReader["cikTar"] != DBNull.Value)
                {
                    araclarmodel.cikTar = Convert.ToDateTime(dataReader["cikTar"]);
                }
            }
            return araclarmodel;
        }

        public int OrtalamaSaatGetir()
        {
            DataIslem veritabani = new DataIslem();
            SqlConnection connection = veritabani.OpenConnection();
            SqlCommand sqlCommand = veritabani.CreateConnection("select AVG(avg_seconds) as avg_seconds from(select  avg(datediff(ms, girTar , cikTar) / 3600000) as avg_seconds from AraclarTable group by Id) as avg_seconds");
            SqlDataReader dataReader = sqlCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            var sonuc = 0;
            while (dataReader.Read())
            {
                if(dataReader["avg_seconds"] !=DBNull.Value)
                {
                    sonuc = Convert.ToInt32(dataReader["avg_seconds"]);

                }
            }
            return sonuc;
        }

        public int UcretGetir()
        {
            DataIslem veritabani = new DataIslem();
            SqlConnection connection = veritabani.OpenConnection();
            SqlCommand sqlCommand = veritabani.CreateConnection("select AVG(avg_seconds) as avg_seconds from(select  avg(datediff(ms, girTar , cikTar) / 3600000)*5 as avg_seconds from AraclarTable group by Id) as avg_seconds");
            SqlDataReader dataReader = sqlCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            var sonuc = 0;
            while (dataReader.Read())
            {
                if (dataReader["avg_seconds"] != DBNull.Value)
                {
                    sonuc = Convert.ToInt32(dataReader["avg_seconds"]);

                }
            }
            return sonuc;
        }

    }
}
