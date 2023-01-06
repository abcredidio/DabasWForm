namespace CadClientesProdutosWForm
{
    partial class MenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SairBTN = new System.Windows.Forms.Button();
            this.MenuCadastroBTN = new System.Windows.Forms.Button();
            this.MenuComprasBTN = new System.Windows.Forms.Button();
            this.MenuVendasBTN = new System.Windows.Forms.Button();
            this.MenuFinanceiroBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // SairBTN
            // 
            resources.ApplyResources(this.SairBTN, "SairBTN");
            this.SairBTN.Name = "SairBTN";
            this.SairBTN.UseVisualStyleBackColor = true;
            this.SairBTN.Click += new System.EventHandler(this.SairBTN_Click);
            // 
            // MenuCadastroBTN
            // 
            resources.ApplyResources(this.MenuCadastroBTN, "MenuCadastroBTN");
            this.MenuCadastroBTN.Name = "MenuCadastroBTN";
            this.MenuCadastroBTN.UseVisualStyleBackColor = true;
            this.MenuCadastroBTN.Click += new System.EventHandler(this.MenuCadastroBTN_Click);
            // 
            // MenuComprasBTN
            // 
            resources.ApplyResources(this.MenuComprasBTN, "MenuComprasBTN");
            this.MenuComprasBTN.Name = "MenuComprasBTN";
            this.MenuComprasBTN.UseVisualStyleBackColor = true;
            this.MenuComprasBTN.Click += new System.EventHandler(this.MenuComprasBTN_Click);
            // 
            // MenuVendasBTN
            // 
            resources.ApplyResources(this.MenuVendasBTN, "MenuVendasBTN");
            this.MenuVendasBTN.Name = "MenuVendasBTN";
            this.MenuVendasBTN.UseVisualStyleBackColor = true;
            this.MenuVendasBTN.Click += new System.EventHandler(this.MenuVendasBTN_Click);
            // 
            // MenuFinanceiroBTN
            // 
            resources.ApplyResources(this.MenuFinanceiroBTN, "MenuFinanceiroBTN");
            this.MenuFinanceiroBTN.Name = "MenuFinanceiroBTN";
            this.MenuFinanceiroBTN.UseVisualStyleBackColor = true;
            this.MenuFinanceiroBTN.Click += new System.EventHandler(this.MenuFinanceiroBTN_Click);
            // 
            // MenuPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ControlBox = false;
            this.Controls.Add(this.MenuFinanceiroBTN);
            this.Controls.Add(this.MenuVendasBTN);
            this.Controls.Add(this.MenuComprasBTN);
            this.Controls.Add(this.MenuCadastroBTN);
            this.Controls.Add(this.SairBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SairBTN;
        private System.Windows.Forms.Button MenuCadastroBTN;
        private System.Windows.Forms.Button MenuComprasBTN;
        private System.Windows.Forms.Button MenuVendasBTN;
        private System.Windows.Forms.Button MenuFinanceiroBTN;
    }
}
