using CadClientesProdutosWForm.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CadClientesProdutosWForm.Produtos
{
    internal class Produto
    {
        public string Nome { get; set; }
        public string Cod { get; set; }
        public int Ncm { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }

        public Produto(string nome, string cod, int ncm, string tipo, string descricao)
        {
            Nome = nome;
            Cod = cod;
            Ncm = ncm;
            Tipo = tipo;
            Descricao = descricao;
        }

        public void InsertSqlProd(Produto produto)
        {
            Connections connection = new Connections();

            string insertString = "INSERT INTO Produtos (Nome, COD, NCM, Tipo, Descrição) VALUES (@nome, @codigo, @ncm, @tipo, @descricao)";
            SqlCommand insertComand = new SqlCommand(insertString, connection.CriarConexaoSql());

            insertComand.Parameters.AddWithValue("@nome", produto.Nome);
            insertComand.Parameters.AddWithValue("@codigo", produto.Cod);
            insertComand.Parameters.AddWithValue("@ncm", produto.Ncm);
            insertComand.Parameters.AddWithValue("@tipo", produto.Tipo);
            insertComand.Parameters.AddWithValue("@descricao", produto.Descricao);

            insertComand.ExecuteNonQuery();
        }
    }
}
