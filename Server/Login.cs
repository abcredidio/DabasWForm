using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CadClientesProdutosWForm.Server
{
    internal class Login
    {
        public string LoginUser { get; set; }
        public string LoginPassword { get; set; }

        public Login(string loginUser, string loginPassword)
        {
            LoginUser = loginUser;
            LoginPassword = loginPassword;
        }


        public bool LoginCheck()
        {
            Connections connection = new Connections();

            string loginCheck = "SELECT * FROM loginUsers WHERE loginUsername = @loginUser AND loginPassword = @loginPass";
            SqlCommand checkCommand = new SqlCommand(loginCheck, connection.CriarConexaoSql());

            checkCommand.Parameters.AddWithValue("@loginUser", LoginUser);
            checkCommand.Parameters.AddWithValue("@loginPass", LoginPassword);

            SqlDataReader reader = checkCommand.ExecuteReader();
            while (reader.Read())
            {
                string dbLoginUser = reader["loginUsername"].ToString();
                string dbPassUser = reader["loginPassword"].ToString();

                if (dbLoginUser.Equals(LoginUser) && dbPassUser.Equals(LoginPassword))
                {
                    return true;
                }
            }
            return false;
        }
    }       
}
