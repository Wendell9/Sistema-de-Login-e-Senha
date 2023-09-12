using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Login
{
    internal class Login
    {
        Conexão con = new Conexão();
        SqlCommand cmd = new SqlCommand();
        public bool logar(string email,string senha) 
        {
            string resultdoSenha = "";

            cmd.CommandText=("select senha from Login where email=@email");
            cmd.Parameters.AddWithValue("@email", email);

            cmd.Connection=con.Conectar();
            using(SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows) 
                {
                while (reader.Read())
                    {
                        resultdoSenha=reader.GetString(0);
                    }
                }
            }
            if(resultdoSenha == senha)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
