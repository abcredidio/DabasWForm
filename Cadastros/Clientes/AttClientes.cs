using CadClientesProdutosWForm.Clientes;
using CadClientesProdutosWForm.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CadClientesProdutosWForm.Cadastros.Clientes
{
    public partial class AttClientes : Form
    {
        public string AttClientIDFieldValue { get { return AttClientIDField.Text; } set { AttClientIDField.Text = value; } }
        public string AttClientCPFValue { get { return AttClientCPFField.Text;} set {AttClientCPFField.Text = value; } }
        public string AttClientNomeValue { get {return AttClientNomeField.Text; } set {AttClientNomeField.Text = value; } }
        public string AttClientEmailValue { get { return AttClientEmailField.Text; } set { AttClientEmailField.Text = value; } }
        public string AttClientDtNascValue { get { return AttClientDtNascField.Text; } set { AttClientDtNascField.Text = value; } }
        public string AttClientCepValue { get { return AttClientCEPField.Text; } set { AttClientCEPField.Text = value; } }
        public string AttClientEnderecoValue { get { return AttClientEnderecoField.Text; } set { AttClientEnderecoField.Text = value; } }
        public string AttClientCompValue { get { return AttClientCompField.Text; } set { AttClientCompField.Text = value; } }
        public string AttClientNrValue { get { return AttClientNrField.Text; } set { AttClientNrField.Text = value; } }
        public string AttClientBairroValue { get { return AttClientBairroField.Text; } set { AttClientBairroField.Text = value; } }
        public string AttClientCidadeValue { get { return AttClientCidadeField.Text; } set { AttClientCidadeField.Text = value; } }
        public string AttClientEstadoValue { get { return AttClientEstadoField.Text; } set { AttClientEstadoField.Text = value; } }
        public string AttClientDtCadastroValue { get { return AttClientDtCadField.Text; } set { AttClientDtCadField.Text = value; } }


        public AttClientes()
        {
            InitializeComponent();
        }

        private void VoltarMenuBTN_Click(object sender, EventArgs e)
        {
            MenuClientes menuClientes = new MenuClientes();
            menuClientes.Show();
            Close();
        }

        private void AttClientAttBTN_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = AttClientNomeField.Text;
            cliente.Email = AttClientEmailField.Text;
            cliente.CEP = int.Parse(AttClientCEPField.Text);
            cliente.Endereco = AttClientEnderecoField.Text;
            cliente.Numero = AttClientNrField.Text;
            cliente.Complemento = AttClientCompField.Text;
            cliente.Cidade = AttClientCidadeField.Text;
            cliente.Uf = AttClientEstadoField.Text;
            cliente.Bairro = AttClientBairroField.Text;

            cliente.UpdateSqlCliente(cliente, int.Parse(AttClientIDField.Text));

            MenuClientes menuClientes = new MenuClientes();
            menuClientes.Show();
            Close();
        }

        private void BuscarCep_Click(object sender, EventArgs e)
        {
            BuscaCEP busca = new BuscaCEP();
            busca.FindCep(AttClientCEPField, AttClientEnderecoField, AttClientBairroField, AttClientEstadoField, AttClientCidadeField);
        }
    }
}
