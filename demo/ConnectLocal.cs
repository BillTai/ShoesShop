using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class ConnectLocal
    {
        string connectionSTR = @"Data Source=DESKTOP-JKPMEMA\SQLEXPRESS;Initial Catalog=Local;Integrated Security=True";
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
    }
}
