using CadClientesProdutosWForm.Produtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CadClientesProdutosWForm
{
    public partial class MenuProdutos : Form
    {
        public MenuProdutos()
        {
            InitializeComponent();
        }

        private void VoltarMenu_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            Hide();
        }

        private void CadProd_Click(object sender, EventArgs e)
        {
            CadProdutos cadProdutos= new CadProdutos();
            cadProdutos.Show();
        }
    }
}
