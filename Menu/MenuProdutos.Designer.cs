namespace CadClientesProdutosWForm
{
    partial class MenuProdutos
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
            this.ExcProd = new System.Windows.Forms.Button();
            this.AltProd = new System.Windows.Forms.Button();
            this.CadProd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VoltarMenu
            // 
            this.VoltarMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VoltarMenu.Location = new System.Drawing.Point(89, 450);
            this.VoltarMenu.Name = "VoltarMenu";
            this.VoltarMenu.Size = new System.Drawing.Size(145, 50);
            this.VoltarMenu.TabIndex = 9;
            this.VoltarMenu.Text = "Voltar para o Menu Cadastros";
            this.VoltarMenu.UseVisualStyleBackColor = true;
            this.VoltarMenu.Click += new System.EventHandler(this.VoltarMenu_Click);
            // 
            // ExcProd
            // 
            this.ExcProd.Enabled = false;
            this.ExcProd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExcProd.Location = new System.Drawing.Point(89, 272);
            this.ExcProd.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.ExcProd.Name = "ExcProd";
            this.ExcProd.Size = new System.Drawing.Size(145, 50);
            this.ExcProd.TabIndex = 8;
            this.ExcProd.Text = "Excluir Produto";
            this.ExcProd.UseVisualStyleBackColor = true;
            // 
            // AltProd
            // 
            this.AltProd.Enabled = false;
            this.AltProd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AltProd.Location = new System.Drawing.Point(89, 189);
            this.AltProd.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.AltProd.Name = "AltProd";
            this.AltProd.Size = new System.Drawing.Size(145, 50);
            this.AltProd.TabIndex = 7;
            this.AltProd.Text = "Alterar dados do Produto";
            this.AltProd.UseVisualStyleBackColor = true;
            // 
            // CadProd
            // 
            this.CadProd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CadProd.Location = new System.Drawing.Point(89, 106);
            this.CadProd.Margin = new System.Windows.Forms.Padding(80, 3, 3, 30);
            this.CadProd.Name = "CadProd";
            this.CadProd.Size = new System.Drawing.Size(145, 50);
            this.CadProd.TabIndex = 6;
            this.CadProd.Text = "Cadastrar Produto";
            this.CadProd.UseVisualStyleBackColor = true;
            this.CadProd.Click += new System.EventHandler(this.CadProd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(89, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Por favor selecione uma das opções: ";
            // 
            // MenuProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.VoltarMenu);
            this.Controls.Add(this.ExcProd);
            this.Controls.Add(this.AltProd);
            this.Controls.Add(this.CadProd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DABAS - Menu Produtos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VoltarMenu;
        private System.Windows.Forms.Button ExcProd;
        private System.Windows.Forms.Button AltProd;
        private System.Windows.Forms.Button CadProd;
        private System.Windows.Forms.Label label1;
    }
}