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
            this.CancelExcClientBTN = new System.Windows.Forms.Button();
            this.DataRefreshExcClienteBTN = new System.Windows.Forms.Button();
            this.ExcClientesExcluirBTN = new System.Windows.Forms.Button();
            this.ExcClientesDTGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ExcClientesDTGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelExcClientBTN
            // 
            this.CancelExcClientBTN.Location = new System.Drawing.Point(12, 451);
            this.CancelExcClientBTN.Name = "CancelExcClientBTN";
            this.CancelExcClientBTN.Size = new System.Drawing.Size(121, 50);
            this.CancelExcClientBTN.TabIndex = 16;
            this.CancelExcClientBTN.Text = "Cancelar";
            this.CancelExcClientBTN.UseVisualStyleBackColor = true;
            this.CancelExcClientBTN.Click += new System.EventHandler(this.CancelExcClientBTN_Click);
            // 
            // DataRefreshExcClienteBTN
            // 
            this.DataRefreshExcClienteBTN.Location = new System.Drawing.Point(254, 12);
            this.DataRefreshExcClienteBTN.Name = "DataRefreshExcClienteBTN";
            this.DataRefreshExcClienteBTN.Size = new System.Drawing.Size(284, 35);
            this.DataRefreshExcClienteBTN.TabIndex = 17;
            this.DataRefreshExcClienteBTN.Text = "Atualizar Dados";
            this.DataRefreshExcClienteBTN.UseVisualStyleBackColor = true;
            this.DataRefreshExcClienteBTN.Click += new System.EventHandler(this.DataRefreshExcClienteBTN_Click);
            // 
            // ExcClientesExcluirBTN
            // 
            this.ExcClientesExcluirBTN.Location = new System.Drawing.Point(667, 451);
            this.ExcClientesExcluirBTN.Name = "ExcClientesExcluirBTN";
            this.ExcClientesExcluirBTN.Size = new System.Drawing.Size(121, 50);
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
            this.ExcClientesDTGrid.Size = new System.Drawing.Size(776, 371);
            this.ExcClientesDTGrid.TabIndex = 18;
            // 
            // ExcClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.ControlBox = false;
            this.Controls.Add(this.ExcClientesExcluirBTN);
            this.Controls.Add(this.ExcClientesDTGrid);
            this.Controls.Add(this.DataRefreshExcClienteBTN);
            this.Controls.Add(this.CancelExcClientBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ExcClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluir Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.ExcClientesDTGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelExcClientBTN;
        private System.Windows.Forms.Button DataRefreshExcClienteBTN;
        private System.Windows.Forms.Button ExcClientesExcluirBTN;
        private System.Windows.Forms.DataGridView ExcClientesDTGrid;
    }
}