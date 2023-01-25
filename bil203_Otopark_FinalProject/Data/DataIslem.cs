using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bil203_Otopark_FinalProject.Data
{
    public class DataIslem
    {
        public SqlConnection OpenConnection()
        {
            //var connetionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=otoparkDB; Integrated Security=True;";
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-S6O6DE1\EBRAR;Initial Catalog=otoparkDB;Integrated Security=True;");
           // SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-MAMHJG5\SQLEXPRESS;Initial Catalog=otoparkDB;Integrated Security=True;");
            baglanti.Open();
            return baglanti;
        }
        // Her sorgu oluşturduğumuzda buradan yararlanacağız.
        public SqlCommand CreateConnection(string sorgu)
        {
            SqlCommand sqlCommand = new SqlCommand(sorgu, OpenConnection());
            return sqlCommand;
        }

    }
}
