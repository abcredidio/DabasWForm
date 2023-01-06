using System;
using System.Data.SqlClient;
using System.Net.Security;
using System.Windows.Forms;
using Microsoft.SqlServer;
using CadClientesProdutosWForm.Server;
using CadClientesProdutosWForm.Clientes;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace CadClientesProdutosWForm.Clientes
{
    public partial class CadClientes : Form
    {

        public string EnderecoClientFieldValue { get {return EnderecoClienteField.Text; } set { EnderecoClienteField.Text = value; } }
        public string BairroClientFieldValue { get { return BairroClienteField.Text; } set { BairroClienteField.Text = value; } }
        public string UfClientFieldValue { get { return UFClienteField.Text; } set { UFClienteField.Text = value; } }
        public string CidadeClientFieldValue { get { return CidadeClienteField.Text; } set { CidadeClienteField.Text = value; } }

        public CadClientes()
        {
            InitializeComponent();
            this.NomeClienteField.GotFocus += new EventHandler(this.NomeClienteField_Click);
        }

        private void NomeClienteField_Click(object sender, EventArgs e)
        {
            ValidateName();
        }

        private bool ValidateName()
        {
            List<TextBox> elementos = new List<TextBox>
            {
                NomeClienteField,
                CpfClienteField,
                EmailClienteField,
                CepClienteField,
                EnderecoClienteField,
                UFClienteField,
                CidadeClienteField,
                BairroClienteField,
                NrClienteField
                
            };
            List<int> soma = new List<int>{};
            foreach (TextBox elemento in elementos)
            {
                if (elemento.Text.Length < 1)
                {
                    errorProvider1.SetError(elemento, "Campo necessário.");
                    soma.Add(1);
                }
                else
                {
                    errorProvider1.Clear();
                    soma.Add(2);
                }
            }
            int sum = soma.Sum();
            if (sum == 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void CancelCdClientBTN_Click(object sender, EventArgs e)
        {
            MenuClientes menuClientes = new MenuClientes();
            menuClientes.Show();
            Close();
        }

        private void InsertCadClientBTN_Click(object sender, EventArgs e)
        {
            if(ValidateName())
            {
                string nome = NomeClienteField.Text;
                string cpf = CpfClienteField.Text;
                string email = EmailClienteField.Text;
                DateTime dtNascimento = DtNascClienteField.Value;
                int cep = int.Parse(CepClienteField.Text);
                string endereco = EnderecoClienteField.Text;
                string numero = NrClienteField.Text;
                string comp = CompClienteField.Text;
                string cidade = CidadeClienteField.Text;
                string uf = UFClienteField.Text;
                string bairro = BairroClienteField.Text;

                Cliente cliente = new Cliente(nome, cpf, email, dtNascimento, cep, endereco, comp, cidade, uf, bairro, numero);

                cliente.InsertSqlCliente(cliente);

                MessageBox.Show("Cliente cadastrado com Sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MenuClientes menuClientes = new MenuClientes();
                menuClientes.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Por favor preencher todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        private void CepClienteField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void CpfClienteField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void BuscarCep_Click(object sender, EventArgs e)
        {
            BuscaCEP busca = new BuscaCEP();
            busca.FindCep(CepClienteField, EnderecoClienteField, BairroClienteField, UFClienteField, CidadeClienteField);
        }
    }
}
