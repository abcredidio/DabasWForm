using CadClientesProdutosWForm.Menu;
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
            MenuCadastros menuCadastros = new MenuCadastros();
            menuCadastros.Show();
            Close();
        }

        private void CadProd_Click(object sender, EventArgs e)
        {
            CadProdutos cadProdutos= new CadProdutos();
            cadProdutos.Show();
            Close();
        }
    }
}
