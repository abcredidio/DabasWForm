using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CadClientesProdutosWForm.Server
{
    public partial class LoginServer : Form
    {
        public LoginServer()
        {
            InitializeComponent();
        }

        private void FecharLogin()
        {
            Close();
        }

        private bool PesquisarLogin()
        {
            Login login = new Login(LoginField.Text, PassField.Text);
            if (login.LoginCheck())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void SairBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {

            if (PesquisarLogin())
            {
                MenuPrincipal menu = new MenuPrincipal();
                MessageBox.Show("Login efetuado com Sucesso.","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                menu.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Dados incorretos, verifique as informações", "Erro", MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }

        }
    }
}
