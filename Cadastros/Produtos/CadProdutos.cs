using CadClientesProdutosWForm.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CadClientesProdutosWForm.Produtos
{
    public partial class CadProdutos : Form
    {
        public CadProdutos()
        {
            InitializeComponent();
        }

        private void CancelCdProdBTN_Click(object sender, EventArgs e)
        {
            MenuProdutos menuProdutos = new MenuProdutos();
            menuProdutos.Show();
            Close();
        }

        private void InsertCadProdBTN_Click(object sender, EventArgs e)
        {
            string nome = NomeProdField.Text;
            string cod = CodProdField.Text;
            int ncm = int.Parse(NCMProdField.Text);
            string tipo = TipoProdField.Text;
            string descricao = DescProdField.Text;

            Produto produto = new Produto(nome, cod, ncm, tipo, descricao);

            produto.InsertSqlProd(produto);

            MessageBox.Show("Produto cadastrado com Sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MenuProdutos menuProdutos = new MenuProdutos();
            menuProdutos.Show();
            Close();
        }
    }
}
