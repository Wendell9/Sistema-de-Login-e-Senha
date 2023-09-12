using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Login
{
    public class Conexão
    {
        SqlConnection con = new SqlConnection();
        public Conexão() 
        {
            con.ConnectionString = "Data Source=DESKTOP-UOHE1VE\\SQLSERVER2022;Initial Catalog=Sistema_Login;Integrated Security=True";
        }
        
        public SqlConnection Conectar()
        {
            if (con.State==System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public SqlConnection Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            return con;
        }
    }
}
