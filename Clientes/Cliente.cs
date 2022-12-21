using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using CadClientesProdutosWForm.Server;

namespace CadClientesProdutosWForm.Clientes
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public string Email { get; set; }
        public DateTime DtNascimento { get; set; }
        public int CEP { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }

        
        public Cliente(string nome, string cPF, string email, DateTime dtNascimento, int cEP, string endereco, string complemento)
        {
            Nome = nome;
            CPF = cPF;
            Email = email;
            DtNascimento = dtNascimento;
            CEP = cEP;
            Endereco = endereco;
            Complemento = complemento;
        }

        public Connections CriarConexãoClientesSql()
        {
            Connections connection = new Connections();
            return connection;
        }

        public void InsertSqlCliente(Cliente cliente)
        {
            string insertString = "INSERT INTO Clientes (Nome, CPF, Email, DtNascimento, CEP, Endereço, Complemento) VALUES (@nome, @cpf, @email, @dtNascimento, @cep, @endereco, @comp)";
            SqlCommand insertComand = new SqlCommand(insertString, CriarConexãoClientesSql().CriarConexaoSql());

            insertComand.Parameters.AddWithValue("@nome", cliente.Nome);
            insertComand.Parameters.AddWithValue("@cpf", cliente.CPF);
            insertComand.Parameters.AddWithValue("@email", cliente.Email);
            insertComand.Parameters.AddWithValue("@dtNascimento", cliente.DtNascimento);
            insertComand.Parameters.AddWithValue("@cep", cliente.CEP);
            insertComand.Parameters.AddWithValue("@endereco", cliente.Endereco);
            insertComand.Parameters.AddWithValue("@comp", cliente.Complemento);

            insertComand.ExecuteNonQuery();
        }

        public void DeleteSqlCliente(Cliente cliente)
        {
            string deleteString = "DELETE FROM Clientes (Nome, CPF)";
            SqlCommand deleteComand = new SqlCommand(deleteString, CriarConexãoClientesSql().CriarConexaoSql());
        }

        public void AtualizarDados()
        {
            var sqlComando = "SELECT Nome, CPF FROM Clientes";
            var dataTable = new DataTable();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlComando, CriarConexãoClientesSql().CriarConexaoSql());

            dataAdapter.Fill(dataTable);          

        }
        public void UpdateSqlCliente()
        {
            string updateString = "UPDATE ";
            SqlCommand updateComand = new SqlCommand(updateString,CriarConexãoClientesSql().CriarConexaoSql());
        }

    }
}
