using CadClientesProdutosWForm;
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
            ExcClientesDTGrid.SelectionChanged += new
            System.EventHandler(ExcClientesDTGrid_SelectionChanged);
        }

        private void AtualizarDTGridView()
        {
            Cliente cliente = new Cliente();
            ExcClientesDTGrid.DataSource = cliente.refresh("SELECT Nome, CPF, Email, DtNascimento, CEP, Endereço, Complemento, Municipio, Estado, Bairro, Numero, DtCadastro FROM Clientes");
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

        private void DataRefreshExcClienteBTN_Click(object sender, EventArgs e)
        {
            AtualizarDTGridView();
        }

        private void ExcClientesExcluirBTN_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            MessageBox.Show($"Cliente {nome} de CPF: {cpf} selecionado", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (ExcClientesDTGrid.SelectedRows.Count == 1)
            {
                ExcClientesConfirmationBox excClientesConfirmationBox = new ExcClientesConfirmationBox();
                excClientesConfirmationBox.ShowDialog();
                if (excClientesConfirmationBox.ExcluirCliente)
                {
                    cliente.ExcluirCliente((string)nome, (string)cpf);
                    AtualizarDTGridView();
                }
            }
            else
            {
                MessageBox.Show("Por favor selecione 1 cliente.","Erro", MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
        }

        private void CancelExcClientBTN_Click(object sender, EventArgs e)
        {
            MenuClientes menuClientes = new MenuClientes();
            menuClientes.Show();
            Close();
        }
    }
}
