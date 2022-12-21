using CadClientesProdutosWForm.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace CadClientesProdutosWForm.Clientes
{
    public partial class ExcClientes : Form
    {
        public string nome { get; set; }
        public string cpf { get; set; }

        public ExcClientes()
        {
            InitializeComponent();
            this.ExcClientesDTGrid.MultiSelect= false;
            refresh();
            ExcClientesDTGrid.SelectionChanged += new
            System.EventHandler(ExcClientesDTGrid_SelectionChanged);
        }


        private void CancelExcClientBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CancelCdClientBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void refresh()
        {
            Connections connection = new Connections();

            var sql = "SELECT Nome, CPF FROM Clientes";
            var da = new SqlDataAdapter(sql, connection.CriarConexaoSql());
            var dt = new DataTable();
            da.Fill(dt);
            ExcClientesDTGrid.DataSource = dt;
        }

        private void ExcClientesDTGrid_SelectionChanged(object sender, EventArgs e)
        {

            if (ExcClientesDTGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ExcClientesDTGrid.SelectedRows[0];

                nome = selectedRow.Cells[0].Value.ToString();
                cpf = selectedRow.Cells[1].Value.ToString();
            }
        }

        private void ExcluirCliente(string nome, string cpf)
        {
            Connections connection = new Connections();

            SqlCommand command = new SqlCommand("DELETE FROM Clientes WHERE Nome = @nome AND CPF = @cpf", connection.CriarConexaoSql());

            command.Parameters.AddWithValue("@nome", nome);
            command.Parameters.AddWithValue("@cpf", cpf);

            command.ExecuteNonQuery();

            MessageBox.Show("Seu cliente foi excluido com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refresh();
        }

        private void DataRefreshExcClienteBTN_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void ExcClientesExcluirBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Cliente {nome} de CPF: {cpf} selecionado", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (ExcClientesDTGrid.SelectedRows.Count == 1)
            {
                ExcClientesConfirmationBox excClientesConfirmationBox = new ExcClientesConfirmationBox();
                excClientesConfirmationBox.ShowDialog();
                if (excClientesConfirmationBox.ExcluirCliente)
                {
                    ExcluirCliente((string)nome, (string)cpf);
                }
            }
            else
            {
                MessageBox.Show("Por favor selecione 1 cliente.","Erro", MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
        }
    }
}
