using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CadClientesProdutosWForm.Clientes;

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
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            Hide();
        }

        private void CadCliente_Click(object sender, EventArgs e)
        {
            CadClientes cadCliente = new CadClientes();
            cadCliente.Show();
        }

        private void ExcCliente_Click(object sender, EventArgs e)
        {
            ExcClientes excClientes = new ExcClientes();
            excClientes.Show();
        }
    }
}
