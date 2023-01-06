using CadClientesProdutosWForm.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CadClientesProdutosWForm.Cadastros.Clientes
{
    public partial class BuscaClientes : Form
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
        public DateTime dtNascimento { get; set; }
        public int cep { get; set; }
        public string endereco { get; set; }
        public string complemento { get; set; }
        public DateTime dtCadastro { get; set; }
        public string estado { get; set; }
        public string municipio { get; set; }
        public string bairro { get; set; }
        public string numero { get; set; }

        public BuscaClientes()
        {
            InitializeComponent();
        }

        private void SearchClientBTN_Click(object sender, EventArgs e)
        {
            var pesquisa = SearchClientField.Text;
            Cliente cliente = new Cliente();
            if (pesquisa != "" )
            {
                DataGridSearchClients.DataSource = cliente.refresh($"SELECT * FROM Clientes WHERE Nome LIKE '%{pesquisa}%'");
            }
            else
            {
                DataGridSearchClients.DataSource = cliente.refresh("SELECT * FROM Clientes");
            }
        }

        private void CancelSearchBTN_Click(object sender, EventArgs e)
        {
            MenuClientes menuClientes = new MenuClientes();
            menuClientes.Show();
            Close();
        }

        private void DataGridSearchClients_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridSearchClients.SelectedRows.Count > 0)
            {
                DataGridViewRow SelectedRow = DataGridSearchClients.SelectedRows[0];

                id = (int)SelectedRow.Cells[0].Value;
                nome = SelectedRow.Cells[1].Value.ToString();
                cpf = SelectedRow.Cells[2].Value.ToString();
                email = SelectedRow.Cells[3].Value.ToString();
                dtNascimento = (DateTime)SelectedRow.Cells[4].Value;
                cep = (int)SelectedRow.Cells[5].Value;
                endereco = SelectedRow.Cells[6].Value.ToString();
                numero = SelectedRow.Cells[7].Value.ToString();
                complemento = SelectedRow.Cells[8].Value.ToString();
                bairro = SelectedRow.Cells[9].Value.ToString();
                municipio = SelectedRow.Cells[10].Value.ToString();
                estado = SelectedRow.Cells[11].Value.ToString();
                dtCadastro = (DateTime)SelectedRow.Cells[12].Value;
            }
        }

        private void SelectClient_Click(object sender, EventArgs e)
        {
            AttClientes attClientes = new AttClientes();

            attClientes.AttClientIDFieldValue = id.ToString();
            attClientes.AttClientNomeValue = nome.ToString();
            attClientes.AttClientCPFValue = cpf.ToString();
            attClientes.AttClientEmailValue = email.ToString();
            attClientes.AttClientDtNascValue = dtNascimento.ToString("dd/MM/yyyy");
            attClientes.AttClientCepValue = cep.ToString();
            attClientes.AttClientEnderecoValue = endereco.ToString();
            attClientes.AttClientNrValue = numero.ToString();
            attClientes.AttClientCompValue = complemento.ToString();
            attClientes.AttClientBairroValue = bairro.ToString();
            attClientes.AttClientCidadeValue = municipio.ToString();
            attClientes.AttClientEstadoValue = estado.ToString();
            attClientes.AttClientDtCadastroValue = dtCadastro.ToString();

            attClientes.Show();

            Close();
        }
    }
}
