using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;    
namespace demo
{
    public class Connect
    {
        string connectionSTR = @"workstation id=ShoesShop.mssql.somee.com;packet size=4096;user id=billTai_SQLLogin_1;pwd=9s3t6kr6j6;data source=ShoesShop.mssql.somee.com;persist security info=False;initial catalog=ShoesShopworkstation id=ShoesShop.mssql.somee.com;packet size=4096;user id=billTai_SQLLogin_1;pwd=9s3t6kr6j6;data source=ShoesShop.mssql.somee.com;persist security info=False;initial catalog=ShoesShop";
        public DataTable ExcuteQuery(string query)
        {
            SqlConnection connect = new SqlConnection(connectionSTR);          
            connect.Open();
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
            adapter.Fill(data);
            connect.Close();           
            return data;            
        }
        public int ExcuteNonQuery(string query)
        {
            int data = 0;
            SqlConnection connect = new SqlConnection(connectionSTR);
            connect.Open();
            SqlCommand command = new SqlCommand(query, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            data = command.ExecuteNonQuery();
            connect.Close();
            return data;
        }

    }
}
