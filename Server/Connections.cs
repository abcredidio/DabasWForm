using CadClientesProdutosWForm.Clientes;
using CadClientesProdutosWForm.Produtos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Security.Principal;

namespace CadClientesProdutosWForm.Server
{
    public class Connections
    {
        public SqlConnection CriarConexaoSql()
        {
            string conectionString = "Server=DESKTOP-8364QKT\\SQLEXPRESS;Database=dabas;User ID=sa;Password=159357";
            SqlConnection connection = new SqlConnection(conectionString);

            connection.Open();
            return connection;
        }                
    }
}
