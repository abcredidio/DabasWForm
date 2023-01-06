using CadClientesProdutosWForm.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CadClientesProdutosWForm.Menu
{
    public partial class MenuCadastros : Form
    {
        public MenuCadastros()
        {
            InitializeComponent();
        }

        private void MenuClientesBTN_Click(object sender, EventArgs e)
        {
            MenuClientes menuClientes= new MenuClientes();
            menuClientes.Show();
            Close();
        }

        private void MenuProdBTN_Click(object sender, EventArgs e)
        {
            MenuProdutos menuProdutos = new MenuProdutos();
            menuProdutos.Show();
            Close();
        }

        private void VoltarMenuBTN_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            Close();
        }
    }
}
