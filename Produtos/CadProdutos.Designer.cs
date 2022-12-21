namespace CadClientesProdutosWForm.Produtos
{
    partial class CadProdutos
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
            this.DescProdField = new System.Windows.Forms.TextBox();
            this.LabelDecCdProd = new System.Windows.Forms.Label();
            this.NCMProdField = new System.Windows.Forms.TextBox();
            this.CodProdField = new System.Windows.Forms.TextBox();
            this.NomeProdField = new System.Windows.Forms.TextBox();
            this.CancelCdProdBTN = new System.Windows.Forms.Button();
            this.InsertCadProdBTN = new System.Windows.Forms.Button();
            this.LabelNcmCdProd = new System.Windows.Forms.Label();
            this.LabelCodCdProd = new System.Windows.Forms.Label();
            this.LabelNomeCdProd = new System.Windows.Forms.Label();
            this.LabelTipoCdProd = new System.Windows.Forms.Label();
            this.TipoProdField = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // DescProdField
            // 
            this.DescProdField.Location = new System.Drawing.Point(131, 201);
            this.DescProdField.Multiline = true;
            this.DescProdField.Name = "DescProdField";
            this.DescProdField.Size = new System.Drawing.Size(179, 85);
            this.DescProdField.TabIndex = 34;
            // 
            // LabelDecCdProd
            // 
            this.LabelDecCdProd.AutoSize = true;
            this.LabelDecCdProd.Location = new System.Drawing.Point(27, 204);
            this.LabelDecCdProd.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.LabelDecCdProd.Name = "LabelDecCdProd";
            this.LabelDecCdProd.Size = new System.Drawing.Size(61, 15);
            this.LabelDecCdProd.TabIndex = 31;
            this.LabelDecCdProd.Text = "Descrição:";
            // 
            // NCMProdField
            // 
            this.NCMProdField.Location = new System.Drawing.Point(131, 111);
            this.NCMProdField.MaxLength = 8;
            this.NCMProdField.Name = "NCMProdField";
            this.NCMProdField.Size = new System.Drawing.Size(179, 23);
            this.NCMProdField.TabIndex = 27;
            // 
            // CodProdField
            // 
            this.CodProdField.Location = new System.Drawing.Point(131, 61);
            this.CodProdField.Name = "CodProdField";
            this.CodProdField.Size = new System.Drawing.Size(179, 23);
            this.CodProdField.TabIndex = 26;
            // 
            // NomeProdField
            // 
            this.NomeProdField.Location = new System.Drawing.Point(131, 16);
            this.NomeProdField.Name = "NomeProdField";
            this.NomeProdField.Size = new System.Drawing.Size(179, 23);
            this.NomeProdField.TabIndex = 25;
            // 
            // CancelCdProdBTN
            // 
            this.CancelCdProdBTN.Location = new System.Drawing.Point(204, 359);
            this.CancelCdProdBTN.Name = "CancelCdProdBTN";
            this.CancelCdProdBTN.Size = new System.Drawing.Size(75, 35);
            this.CancelCdProdBTN.TabIndex = 36;
            this.CancelCdProdBTN.Text = "Cancelar";
            this.CancelCdProdBTN.UseVisualStyleBackColor = true;
            this.CancelCdProdBTN.Click += new System.EventHandler(this.CancelCdProdBTN_Click);
            // 
            // InsertCadProdBTN
            // 
            this.InsertCadProdBTN.Location = new System.Drawing.Point(58, 359);
            this.InsertCadProdBTN.Name = "InsertCadProdBTN";
            this.InsertCadProdBTN.Size = new System.Drawing.Size(75, 35);
            this.InsertCadProdBTN.TabIndex = 35;
            this.InsertCadProdBTN.Text = "Inserir";
            this.InsertCadProdBTN.UseVisualStyleBackColor = true;
            this.InsertCadProdBTN.Click += new System.EventHandler(this.InsertCadProdBTN_Click);
            // 
            // LabelNcmCdProd
            // 
            this.LabelNcmCdProd.AutoSize = true;
            this.LabelNcmCdProd.Location = new System.Drawing.Point(27, 114);
            this.LabelNcmCdProd.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.LabelNcmCdProd.Name = "LabelNcmCdProd";
            this.LabelNcmCdProd.Size = new System.Drawing.Size(41, 15);
            this.LabelNcmCdProd.TabIndex = 21;
            this.LabelNcmCdProd.Text = "NCM: ";
            this.LabelNcmCdProd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelCodCdProd
            // 
            this.LabelCodCdProd.AutoSize = true;
            this.LabelCodCdProd.Location = new System.Drawing.Point(27, 64);
            this.LabelCodCdProd.Margin = new System.Windows.Forms.Padding(3, 0, 3, 35);
            this.LabelCodCdProd.Name = "LabelCodCdProd";
            this.LabelCodCdProd.Size = new System.Drawing.Size(52, 15);
            this.LabelCodCdProd.TabIndex = 20;
            this.LabelCodCdProd.Text = "Código: ";
            // 
            // LabelNomeCdProd
            // 
            this.LabelNomeCdProd.AutoSize = true;
            this.LabelNomeCdProd.Location = new System.Drawing.Point(27, 19);
            this.LabelNomeCdProd.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.LabelNomeCdProd.Name = "LabelNomeCdProd";
            this.LabelNomeCdProd.Size = new System.Drawing.Size(46, 15);
            this.LabelNomeCdProd.TabIndex = 19;
            this.LabelNomeCdProd.Text = "Nome: ";
            // 
            // LabelTipoCdProd
            // 
            this.LabelTipoCdProd.AutoSize = true;
            this.LabelTipoCdProd.Location = new System.Drawing.Point(27, 159);
            this.LabelTipoCdProd.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.LabelTipoCdProd.Name = "LabelTipoCdProd";
            this.LabelTipoCdProd.Size = new System.Drawing.Size(95, 15);
            this.LabelTipoCdProd.TabIndex = 33;
            this.LabelTipoCdProd.Text = "Tipo de Produto:";
            this.LabelTipoCdProd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TipoProdField
            // 
            this.TipoProdField.FormattingEnabled = true;
            this.TipoProdField.Items.AddRange(new object[] {
            "Materia Prima",
            "Revenda",
            "Consumo",
            "Produção Própria"});
            this.TipoProdField.Location = new System.Drawing.Point(131, 156);
            this.TipoProdField.Name = "TipoProdField";
            this.TipoProdField.Size = new System.Drawing.Size(179, 23);
            this.TipoProdField.TabIndex = 32;
            // 
            // CadProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.ControlBox = false;
            this.Controls.Add(this.TipoProdField);
            this.Controls.Add(this.LabelTipoCdProd);
            this.Controls.Add(this.DescProdField);
            this.Controls.Add(this.LabelDecCdProd);
            this.Controls.Add(this.NCMProdField);
            this.Controls.Add(this.CodProdField);
            this.Controls.Add(this.NomeProdField);
            this.Controls.Add(this.CancelCdProdBTN);
            this.Controls.Add(this.InsertCadProdBTN);
            this.Controls.Add(this.LabelNcmCdProd);
            this.Controls.Add(this.LabelCodCdProd);
            this.Controls.Add(this.LabelNomeCdProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CadProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DABAS - Cadastro de Produtos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox DescProdField;
        private System.Windows.Forms.Label LabelDecCdProd;
        private System.Windows.Forms.TextBox NCMProdField;
        private System.Windows.Forms.TextBox CodProdField;
        private System.Windows.Forms.TextBox NomeProdField;
        private System.Windows.Forms.Button CancelCdProdBTN;
        private System.Windows.Forms.Button InsertCadProdBTN;
        private System.Windows.Forms.Label LabelNcmCdProd;
        private System.Windows.Forms.Label LabelCodCdProd;
        private System.Windows.Forms.Label LabelNomeCdProd;
        private System.Windows.Forms.Label LabelTipoCdProd;
        private System.Windows.Forms.ComboBox TipoProdField;
    }
}