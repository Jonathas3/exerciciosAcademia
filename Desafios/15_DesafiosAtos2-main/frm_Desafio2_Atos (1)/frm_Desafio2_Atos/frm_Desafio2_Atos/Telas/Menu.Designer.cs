namespace frm_Desafio2_Atos
{
    partial class frm_Principal
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
            this.botao_Vendas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botao_Cad_Forn = new System.Windows.Forms.Button();
            this.botao_Pg_Cliente = new System.Windows.Forms.Button();
            this.botao_Cad_Prod = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botao_Vendas
            // 
            this.botao_Vendas.Location = new System.Drawing.Point(275, 181);
            this.botao_Vendas.Name = "botao_Vendas";
            this.botao_Vendas.Size = new System.Drawing.Size(203, 76);
            this.botao_Vendas.TabIndex = 4;
            this.botao_Vendas.Text = "Vender";
            this.botao_Vendas.UseVisualStyleBackColor = true;
            this.botao_Vendas.Click += new System.EventHandler(this.botao_Vendas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botao_Cad_Forn);
            this.groupBox1.Controls.Add(this.botao_Pg_Cliente);
            this.groupBox1.Controls.Add(this.botao_Cad_Prod);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 142);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CADASTROS";
            // 
            // botao_Cad_Forn
            // 
            this.botao_Cad_Forn.Location = new System.Drawing.Point(263, 35);
            this.botao_Cad_Forn.Name = "botao_Cad_Forn";
            this.botao_Cad_Forn.Size = new System.Drawing.Size(203, 72);
            this.botao_Cad_Forn.TabIndex = 6;
            this.botao_Cad_Forn.Text = "Cadastrar Fornecedores";
            this.botao_Cad_Forn.UseVisualStyleBackColor = true;
            this.botao_Cad_Forn.Click += new System.EventHandler(this.botao_Cad_Forn_Click_1);
            // 
            // botao_Pg_Cliente
            // 
            this.botao_Pg_Cliente.Location = new System.Drawing.Point(517, 35);
            this.botao_Pg_Cliente.Name = "botao_Pg_Cliente";
            this.botao_Pg_Cliente.Size = new System.Drawing.Size(203, 72);
            this.botao_Pg_Cliente.TabIndex = 5;
            this.botao_Pg_Cliente.Text = "Cadastrar Clientes";
            this.botao_Pg_Cliente.UseVisualStyleBackColor = true;
            this.botao_Pg_Cliente.Click += new System.EventHandler(this.botao_Pg_Cliente_Click);
            // 
            // botao_Cad_Prod
            // 
            this.botao_Cad_Prod.Location = new System.Drawing.Point(8, 35);
            this.botao_Cad_Prod.Name = "botao_Cad_Prod";
            this.botao_Cad_Prod.Size = new System.Drawing.Size(203, 72);
            this.botao_Cad_Prod.TabIndex = 4;
            this.botao_Cad_Prod.Text = "Cadastrar Produtos";
            this.botao_Cad_Prod.UseVisualStyleBackColor = true;
            this.botao_Cad_Prod.Click += new System.EventHandler(this.botao_Cad_Prod_Click_1);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(754, 490);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botao_Vendas);
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button botao_Vendas;
        private GroupBox groupBox1;
        private Button botao_Cad_Forn;
        private Button botao_Pg_Cliente;
        private Button botao_Cad_Prod;
    }
}