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

namespace CadClientesProdutosWForm.Clientes
{
    public partial class CadClientes : Form
    {
        
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
                CompClienteField
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
            if (sum == 12)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CancelCdClientBTN_Click(object sender, EventArgs e)
        {
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
                string comp = CompClienteField.Text;

                Cliente cliente = new Cliente(nome, cpf, email, dtNascimento, cep, endereco, comp);

                cliente.InsertSqlCliente(cliente);

                MessageBox.Show("Cliente cadastrado com Sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            else
            {
                MessageBox.Show("Por favor preencher todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }
    }
}
