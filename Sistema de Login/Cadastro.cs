using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Login
{
    public class Cadastro
    {
        public string mensagem;
        Conexão conexão = new Conexão();
        SqlCommand cmd = new SqlCommand();
        public string Cadastrar(string Email, string Senha)
        {
            cmd.CommandText = "insert into Login (email,senha) values (@email,@senha)";
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@senha", Senha);

            try
            {
                cmd.Connection = conexão.Conectar();
                cmd.ExecuteNonQuery();
                conexão.Desconectar();
                mensagem = "Cadastrado com sucesso!";
                return mensagem;

            }
            catch (SqlException)
            {
                mensagem = "Erro ao conectar ao Danco de Dados";
                return mensagem;
            }
        }

        public bool verificaemail(string email)
        {
            try
            {
                string emailcontrole = "";
                cmd.CommandText = "select email from Login where email=@email";
                cmd.Parameters.AddWithValue("@email", email);

                cmd.Connection = conexão.Conectar();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            emailcontrole = reader.GetString(0);
                        }
                    }
                }
                cmd.Parameters.Clear();
                conexão.Desconectar();

                if (emailcontrole == "")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(mensagem, ex);
            }
        }
    }
}
