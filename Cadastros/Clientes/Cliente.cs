using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
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
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Bairro { get; set; }


        public Cliente(string nome, string cPF, string email, DateTime dtNascimento, int cEP, string endereco, string complemento, string cidade, string uf, string bairro, string numero)
        {
            Nome = nome;
            CPF = cPF;
            Email = email;
            DtNascimento = dtNascimento;
            CEP = cEP;
            Endereco = endereco;
            Complemento = complemento;
            Cidade = cidade;
            Uf = uf;
            Bairro = bairro;
            Numero = numero;
        }

        public Cliente(string nome, string cPF)
        {
            Nome = nome;
            CPF = cPF;
        }

        public Cliente()
        {
        }

        public Connections CriarConexãoClientesSql()
        {
            Connections connection = new Connections();
            return connection;
        }

        public void InsertSqlCliente(Cliente cliente)
        {
            string insertString = "INSERT INTO Clientes (Nome, CPF, Email, DtNascimento, CEP, Endereço, Complemento, Municipio, Estado, Bairro, Numero) VALUES (@nome, @cpf, @email, @dtNascimento, @cep, @endereco, @comp, @cidade, @uf, @bairro, @numero)";
            SqlCommand insertComand = new SqlCommand(insertString, CriarConexãoClientesSql().CriarConexaoSql());

            insertComand.Parameters.AddWithValue("@nome", cliente.Nome);
            insertComand.Parameters.AddWithValue("@cpf", cliente.CPF);
            insertComand.Parameters.AddWithValue("@email", cliente.Email);
            insertComand.Parameters.AddWithValue("@dtNascimento", cliente.DtNascimento);
            insertComand.Parameters.AddWithValue("@cep", cliente.CEP);
            insertComand.Parameters.AddWithValue("@endereco", cliente.Endereco);
            insertComand.Parameters.AddWithValue("@numero", cliente.Numero);
            insertComand.Parameters.AddWithValue("@comp", cliente.Complemento);
            insertComand.Parameters.AddWithValue("@cidade", cliente.Cidade);
            insertComand.Parameters.AddWithValue("@uf", cliente.Uf);
            insertComand.Parameters.AddWithValue("@bairro", cliente.Bairro);

            insertComand.ExecuteNonQuery();

            CriarConexãoClientesSql().CriarConexaoSql().Close();
        }

        public void UpdateSqlCliente(Cliente cliente, int id)
        {
            Connections connection = new Connections();
            string updateString = $"UPDATE Clientes SET Nome = @nome, Email = @Email, CEP = @cep, Endereço = @endereco, Numero = @nr ,Complemento = @comp, Municipio = @cidade, Estado = @uf, Bairro = @bairro WHERE ID = {id} ";
            SqlCommand updateComand = new SqlCommand(updateString,CriarConexãoClientesSql().CriarConexaoSql());

            updateComand.Parameters.AddWithValue("@nome", cliente.Nome);
            updateComand.Parameters.AddWithValue("@email", cliente.Email);
            updateComand.Parameters.AddWithValue("@cep", cliente.CEP);
            updateComand.Parameters.AddWithValue("@endereco", cliente.Endereco);
            updateComand.Parameters.AddWithValue("@nr", cliente.Numero);
            updateComand.Parameters.AddWithValue("@comp", cliente.Complemento);
            updateComand.Parameters.AddWithValue("@cidade", cliente.Cidade);
            updateComand.Parameters.AddWithValue("@uf", cliente.Uf);
            updateComand.Parameters.AddWithValue("@bairro", cliente.Bairro);

            updateComand.ExecuteNonQuery();

            CriarConexãoClientesSql().CriarConexaoSql().Close();

            MessageBox.Show("Cliente atualizado com Sucesso!");
        }


        internal void ExcluirCliente(string nome, string cpf)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Clientes WHERE Nome = @nome AND CPF = @cpf", CriarConexãoClientesSql().CriarConexaoSql());

            command.Parameters.AddWithValue("@nome", nome);
            command.Parameters.AddWithValue("@cpf", cpf);

            command.ExecuteNonQuery();

            MessageBox.Show("Seu cliente foi excluido com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refresh("SELECT Nome, CPF FROM Clientes");

            CriarConexãoClientesSql().CriarConexaoSql().Close();
        }

        internal DataTable refresh(string sql) //DataTable Clientes
        {
                        
            var da = new SqlDataAdapter(sql, CriarConexãoClientesSql().CriarConexaoSql());
            var dt = new DataTable();
            da.Fill(dt);
            CriarConexãoClientesSql().CriarConexaoSql().Close();

            return dt;

        }

    }
}
