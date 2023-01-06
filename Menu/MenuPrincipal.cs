using CadClientesProdutosWForm.Clientes;
using CadClientesProdutosWForm.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadClientesProdutosWForm
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        private void MenuClientesBTN_Click(object sender, EventArgs e)
        {
            MenuClientes menuclientes = new MenuClientes();
            menuclientes.Show();
            Close();
        }

        private void SairBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void MenuProdBTN_Click(object sender, EventArgs e)
        {
            MenuProdutos menuProdutos = new MenuProdutos();
            menuProdutos.Show();
            Close();
        }

        private void BotaoDeTestes_Click(object sender, EventArgs e)
        {

        }

        private void MenuCadastroBTN_Click(object sender, EventArgs e)
        {
            MenuCadastros menuCadastro = new MenuCadastros();
            menuCadastro.Show();
            Close();
        }

        private void MenuComprasBTN_Click(object sender, EventArgs e)
        {
            MenuCompras menuCompras = new MenuCompras();
            menuCompras.Show();
            Close();
        }

        private void MenuVendasBTN_Click(object sender, EventArgs e)
        {
            MenuVendas menuVendas = new MenuVendas();
            menuVendas.Show();
            Close();
        }

        private void MenuFinanceiroBTN_Click(object sender, EventArgs e)
        {
            MenuFinanceiro menuFinanceiro = new MenuFinanceiro();
            menuFinanceiro.Show();
            Close();
        }
    }
}
