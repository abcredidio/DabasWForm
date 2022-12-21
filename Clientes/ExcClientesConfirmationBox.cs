using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CadClientesProdutosWForm.Clientes
{
    public partial class ExcClientesConfirmationBox : Form
    {
        public ExcClientesConfirmationBox()
        {
            InitializeComponent();
        }

        public bool ExcluirCliente { get; set; } = false;

        private void ExcClienteNOConfirmBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExcClienteConfirmBTN_Click(object sender, EventArgs e)
        {
            Close();
            ExcluirCliente = true;
        }
    }
}
