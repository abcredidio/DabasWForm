namespace CadClientesProdutosWForm
{
    partial class MenuClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.VoltarMenu = new System.Windows.Forms.Button();
            this.ExcCliente = new System.Windows.Forms.Button();
            this.AltCliente = new System.Windows.Forms.Button();
            this.CadCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VoltarMenu
            // 
            this.VoltarMenu.Location = new System.Drawing.Point(89, 450);
            this.VoltarMenu.Name = "VoltarMenu";
            this.VoltarMenu.Size = new System.Drawing.Size(145, 50);
            this.VoltarMenu.TabIndex = 14;
            this.VoltarMenu.Text = "Voltar para o Menu Principal";
            this.VoltarMenu.UseVisualStyleBackColor = true;
            this.VoltarMenu.Click += new System.EventHandler(this.VoltarMenu_Click);
            // 
            // ExcCliente
            // 
            this.ExcCliente.Location = new System.Drawing.Point(89, 272);
            this.ExcCliente.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.ExcCliente.Name = "ExcCliente";
            this.ExcCliente.Size = new System.Drawing.Size(145, 50);
            this.ExcCliente.TabIndex = 13;
            this.ExcCliente.Text = "Excluir Cliente";
            this.ExcCliente.UseVisualStyleBackColor = true;
            this.ExcCliente.Click += new System.EventHandler(this.ExcCliente_Click);
            // 
            // AltCliente
            // 
            this.AltCliente.Enabled = false;
            this.AltCliente.Location = new System.Drawing.Point(89, 189);
            this.AltCliente.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.AltCliente.Name = "AltCliente";
            this.AltCliente.Size = new System.Drawing.Size(145, 50);
            this.AltCliente.TabIndex = 12;
            this.AltCliente.Text = "Alterar dados do Cliente";
            this.AltCliente.UseVisualStyleBackColor = true;
            // 
            // CadCliente
            // 
            this.CadCliente.Location = new System.Drawing.Point(89, 106);
            this.CadCliente.Margin = new System.Windows.Forms.Padding(80, 3, 3, 30);
            this.CadCliente.Name = "CadCliente";
            this.CadCliente.Size = new System.Drawing.Size(145, 50);
            this.CadCliente.TabIndex = 11;
            this.CadCliente.Text = "Cadastrar Clientes";
            this.CadCliente.UseVisualStyleBackColor = true;
            this.CadCliente.Click += new System.EventHandler(this.CadCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(89, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Por favor selecione uma das opções: ";
            // 
            // MenuClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.VoltarMenu);
            this.Controls.Add(this.ExcCliente);
            this.Controls.Add(this.AltCliente);
            this.Controls.Add(this.CadCliente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DABAS - Menu Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VoltarMenu;
        private System.Windows.Forms.Button ExcCliente;
        private System.Windows.Forms.Button AltCliente;
        private System.Windows.Forms.Button CadCliente;
        private System.Windows.Forms.Label label1;
    }
}