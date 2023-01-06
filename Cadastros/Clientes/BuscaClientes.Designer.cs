namespace CadClientesProdutosWForm.Cadastros.Clientes
{
    partial class BuscaClientes
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
            this.SearchClientField = new System.Windows.Forms.TextBox();
            this.SearchClientBTN = new System.Windows.Forms.Button();
            this.DataGridSearchClients = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectClient = new System.Windows.Forms.Button();
            this.CancelSearchBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSearchClients)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchClientField
            // 
            this.SearchClientField.Location = new System.Drawing.Point(160, 27);
            this.SearchClientField.Name = "SearchClientField";
            this.SearchClientField.Size = new System.Drawing.Size(460, 23);
            this.SearchClientField.TabIndex = 0;
            // 
            // SearchClientBTN
            // 
            this.SearchClientBTN.Location = new System.Drawing.Point(626, 27);
            this.SearchClientBTN.Name = "SearchClientBTN";
            this.SearchClientBTN.Size = new System.Drawing.Size(115, 23);
            this.SearchClientBTN.TabIndex = 1;
            this.SearchClientBTN.Text = "Pesquisar";
            this.SearchClientBTN.UseVisualStyleBackColor = true;
            this.SearchClientBTN.Click += new System.EventHandler(this.SearchClientBTN_Click);
            // 
            // DataGridSearchClients
            // 
            this.DataGridSearchClients.AllowUserToAddRows = false;
            this.DataGridSearchClients.AllowUserToDeleteRows = false;
            this.DataGridSearchClients.AllowUserToResizeRows = false;
            this.DataGridSearchClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridSearchClients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridSearchClients.Location = new System.Drawing.Point(12, 57);
            this.DataGridSearchClients.MultiSelect = false;
            this.DataGridSearchClients.Name = "DataGridSearchClients";
            this.DataGridSearchClients.RowHeadersVisible = false;
            this.DataGridSearchClients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridSearchClients.RowTemplate.Height = 25;
            this.DataGridSearchClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridSearchClients.Size = new System.Drawing.Size(776, 388);
            this.DataGridSearchClients.TabIndex = 2;
            this.DataGridSearchClients.SelectionChanged += new System.EventHandler(this.DataGridSearchClients_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite o Nome do cliente:";
            // 
            // SelectClient
            // 
            this.SelectClient.Location = new System.Drawing.Point(667, 451);
            this.SelectClient.Name = "SelectClient";
            this.SelectClient.Size = new System.Drawing.Size(121, 50);
            this.SelectClient.TabIndex = 4;
            this.SelectClient.Text = "Selecionar";
            this.SelectClient.UseVisualStyleBackColor = true;
            this.SelectClient.Click += new System.EventHandler(this.SelectClient_Click);
            // 
            // CancelSearchBTN
            // 
            this.CancelSearchBTN.Location = new System.Drawing.Point(12, 451);
            this.CancelSearchBTN.Name = "CancelSearchBTN";
            this.CancelSearchBTN.Size = new System.Drawing.Size(121, 50);
            this.CancelSearchBTN.TabIndex = 6;
            this.CancelSearchBTN.Text = "Cancelar";
            this.CancelSearchBTN.UseVisualStyleBackColor = true;
            this.CancelSearchBTN.Click += new System.EventHandler(this.CancelSearchBTN_Click);
            // 
            // BuscaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.ControlBox = false;
            this.Controls.Add(this.CancelSearchBTN);
            this.Controls.Add(this.SelectClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridSearchClients);
            this.Controls.Add(this.SearchClientBTN);
            this.Controls.Add(this.SearchClientField);
            this.Name = "BuscaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscaClientes";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSearchClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchClientField;
        private System.Windows.Forms.Button SearchClientBTN;
        private System.Windows.Forms.DataGridView DataGridSearchClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SelectClient;
        private System.Windows.Forms.Button CancelSearchBTN;
    }
}