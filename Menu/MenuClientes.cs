using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CadClientesProdutosWForm.Cadastros.Clientes;
using CadClientesProdutosWForm.Clientes;
using CadClientesProdutosWForm.Menu;

namespace CadClientesProdutosWForm
{
    public partial class MenuClientes : Form
    {
        public MenuClientes()
        {
            InitializeComponent();
        }

        private void VoltarMenu_Click(object sender, EventArgs e)
        {
            MenuCadastros menuCadastros = new MenuCadastros();
            menuCadastros.Show();
            Close();
        }

        private void CadCliente_Click(object sender, EventArgs e)
        {
            CadClientes cadCliente = new CadClientes();
            cadCliente.Show();   
            Close();
        }

        private void ExcCliente_Click(object sender, EventArgs e)
        {
            ExcClientes excClientes = new ExcClientes();
            excClientes.Show();
            Close();
        }

        private void AltCliente_Click(object sender, EventArgs e)
        {
            BuscaClientes buscaClientes = new BuscaClientes();
            buscaClientes.Show();
            Close();
        }
    }
}
