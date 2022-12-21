namespace CadClientesProdutosWForm.Clientes
{
    partial class ExcClientes
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
            this.CancelCdClientBTN = new System.Windows.Forms.Button();
            this.DataRefreshExcClienteBTN = new System.Windows.Forms.Button();
            this.ExcClientesExcluirBTN = new System.Windows.Forms.Button();
            this.ExcClientesDTGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ExcClientesDTGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelCdClientBTN
            // 
            this.CancelCdClientBTN.Location = new System.Drawing.Point(137, 344);
            this.CancelCdClientBTN.Name = "CancelCdClientBTN";
            this.CancelCdClientBTN.Size = new System.Drawing.Size(75, 35);
            this.CancelCdClientBTN.TabIndex = 16;
            this.CancelCdClientBTN.Text = "Cancelar";
            this.CancelCdClientBTN.UseVisualStyleBackColor = true;
            this.CancelCdClientBTN.Click += new System.EventHandler(this.CancelCdClientBTN_Click);
            // 
            // DataRefreshExcClienteBTN
            // 
            this.DataRefreshExcClienteBTN.Location = new System.Drawing.Point(12, 12);
            this.DataRefreshExcClienteBTN.Name = "DataRefreshExcClienteBTN";
            this.DataRefreshExcClienteBTN.Size = new System.Drawing.Size(200, 35);
            this.DataRefreshExcClienteBTN.TabIndex = 17;
            this.DataRefreshExcClienteBTN.Text = "Atualizar Dados";
            this.DataRefreshExcClienteBTN.UseVisualStyleBackColor = true;
            this.DataRefreshExcClienteBTN.Click += new System.EventHandler(this.DataRefreshExcClienteBTN_Click);
            // 
            // ExcClientesExcluirBTN
            // 
            this.ExcClientesExcluirBTN.Location = new System.Drawing.Point(12, 344);
            this.ExcClientesExcluirBTN.Name = "ExcClientesExcluirBTN";
            this.ExcClientesExcluirBTN.Size = new System.Drawing.Size(75, 35);
            this.ExcClientesExcluirBTN.TabIndex = 19;
            this.ExcClientesExcluirBTN.Text = "Excluir";
            this.ExcClientesExcluirBTN.UseVisualStyleBackColor = true;
            this.ExcClientesExcluirBTN.Click += new System.EventHandler(this.ExcClientesExcluirBTN_Click);
            // 
            // ExcClientesDTGrid
            // 
            this.ExcClientesDTGrid.AllowUserToAddRows = false;
            this.ExcClientesDTGrid.AllowUserToDeleteRows = false;
            this.ExcClientesDTGrid.AllowUserToResizeColumns = false;
            this.ExcClientesDTGrid.AllowUserToResizeRows = false;
            this.ExcClientesDTGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExcClientesDTGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ExcClientesDTGrid.Location = new System.Drawing.Point(12, 67);
            this.ExcClientesDTGrid.MultiSelect = false;
            this.ExcClientesDTGrid.Name = "ExcClientesDTGrid";
            this.ExcClientesDTGrid.RowHeadersVisible = false;
            this.ExcClientesDTGrid.RowTemplate.Height = 25;
            this.ExcClientesDTGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExcClientesDTGrid.Size = new System.Drawing.Size(200, 257);
            this.ExcClientesDTGrid.TabIndex = 18;
            // 
            // ExcClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 391);
            this.ControlBox = false;
            this.Controls.Add(this.ExcClientesExcluirBTN);
            this.Controls.Add(this.ExcClientesDTGrid);
            this.Controls.Add(this.DataRefreshExcClienteBTN);
            this.Controls.Add(this.CancelCdClientBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ExcClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DABAS - Excluir Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.ExcClientesDTGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelCdClientBTN;
        private System.Windows.Forms.Button DataRefreshExcClienteBTN;
        private System.Windows.Forms.Button ExcClientesExcluirBTN;
        private System.Windows.Forms.DataGridView ExcClientesDTGrid;
    }
}