namespace CadClientesProdutosWForm.Clientes
{
    partial class ExcClientesConfirmationBox
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
            this.ExcClienteConfirmLabel = new System.Windows.Forms.Label();
            this.ExcClienteConfirmBTN = new System.Windows.Forms.Button();
            this.ExcClienteNOConfirmBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExcClienteConfirmLabel
            // 
            this.ExcClienteConfirmLabel.AutoSize = true;
            this.ExcClienteConfirmLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExcClienteConfirmLabel.Location = new System.Drawing.Point(24, 38);
            this.ExcClienteConfirmLabel.Name = "ExcClienteConfirmLabel";
            this.ExcClienteConfirmLabel.Size = new System.Drawing.Size(186, 21);
            this.ExcClienteConfirmLabel.TabIndex = 0;
            this.ExcClienteConfirmLabel.Text = "Deseja realmente excluir?";
            // 
            // ExcClienteConfirmBTN
            // 
            this.ExcClienteConfirmBTN.Location = new System.Drawing.Point(24, 93);
            this.ExcClienteConfirmBTN.Name = "ExcClienteConfirmBTN";
            this.ExcClienteConfirmBTN.Size = new System.Drawing.Size(75, 35);
            this.ExcClienteConfirmBTN.TabIndex = 1;
            this.ExcClienteConfirmBTN.Text = "Sim";
            this.ExcClienteConfirmBTN.UseVisualStyleBackColor = true;
            this.ExcClienteConfirmBTN.Click += new System.EventHandler(this.ExcClienteConfirmBTN_Click);
            // 
            // ExcClienteNOConfirmBTN
            // 
            this.ExcClienteNOConfirmBTN.Location = new System.Drawing.Point(135, 93);
            this.ExcClienteNOConfirmBTN.Name = "ExcClienteNOConfirmBTN";
            this.ExcClienteNOConfirmBTN.Size = new System.Drawing.Size(75, 35);
            this.ExcClienteNOConfirmBTN.TabIndex = 2;
            this.ExcClienteNOConfirmBTN.Text = "Não";
            this.ExcClienteNOConfirmBTN.UseVisualStyleBackColor = true;
            this.ExcClienteNOConfirmBTN.Click += new System.EventHandler(this.ExcClienteNOConfirmBTN_Click);
            // 
            // ExcClientesConfirmationBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(238, 149);
            this.ControlBox = false;
            this.Controls.Add(this.ExcClienteNOConfirmBTN);
            this.Controls.Add(this.ExcClienteConfirmBTN);
            this.Controls.Add(this.ExcClienteConfirmLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ExcClientesConfirmationBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluir Cliente?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExcClienteConfirmLabel;
        private System.Windows.Forms.Button ExcClienteConfirmBTN;
        private System.Windows.Forms.Button ExcClienteNOConfirmBTN;
    }
}