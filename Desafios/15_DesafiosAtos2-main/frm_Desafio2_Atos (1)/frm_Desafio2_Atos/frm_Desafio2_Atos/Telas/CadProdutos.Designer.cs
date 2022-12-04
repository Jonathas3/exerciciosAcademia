namespace frm_Desafio2_Atos
{
    partial class frm_Produto
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
            this.botao_ExcluirProd = new System.Windows.Forms.Button();
            this.grid_Produto = new System.Windows.Forms.DataGridView();
            this.botao_Voltar = new System.Windows.Forms.Button();
            this.botao_buscaProduto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Valor = new System.Windows.Forms.NumericUpDown();
            this.botao_AddProd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_NomeProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Produto)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_Valor)).BeginInit();
            this.SuspendLayout();
            // 
            // botao_ExcluirProd
            // 
            this.botao_ExcluirProd.Location = new System.Drawing.Point(423, 178);
            this.botao_ExcluirProd.Name = "botao_ExcluirProd";
            this.botao_ExcluirProd.Size = new System.Drawing.Size(115, 38);
            this.botao_ExcluirProd.TabIndex = 5;
            this.botao_ExcluirProd.Text = "Excluir Produto";
            this.botao_ExcluirProd.UseVisualStyleBackColor = true;
            this.botao_ExcluirProd.Click += new System.EventHandler(this.botao_ExcluirProd_Click);
            // 
            // grid_Produto
            // 
            this.grid_Produto.AllowUserToAddRows = false;
            this.grid_Produto.AllowUserToDeleteRows = false;
            this.grid_Produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Produto.Location = new System.Drawing.Point(46, 235);
            this.grid_Produto.Name = "grid_Produto";
            this.grid_Produto.ReadOnly = true;
            this.grid_Produto.RowTemplate.Height = 25;
            this.grid_Produto.Size = new System.Drawing.Size(492, 216);
            this.grid_Produto.TabIndex = 7;
            this.grid_Produto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Produto_CellContentClick);
            // 
            // botao_Voltar
            // 
            this.botao_Voltar.Location = new System.Drawing.Point(587, 412);
            this.botao_Voltar.Name = "botao_Voltar";
            this.botao_Voltar.Size = new System.Drawing.Size(114, 39);
            this.botao_Voltar.TabIndex = 8;
            this.botao_Voltar.Text = "Voltar";
            this.botao_Voltar.UseVisualStyleBackColor = true;
            this.botao_Voltar.Click += new System.EventHandler(this.botao_Voltar_Click);
            // 
            // botao_buscaProduto
            // 
            this.botao_buscaProduto.Location = new System.Drawing.Point(46, 178);
            this.botao_buscaProduto.Name = "botao_buscaProduto";
            this.botao_buscaProduto.Size = new System.Drawing.Size(115, 39);
            this.botao_buscaProduto.TabIndex = 11;
            this.botao_buscaProduto.Text = "Consultar";
            this.botao_buscaProduto.UseVisualStyleBackColor = true;
            this.botao_buscaProduto.Click += new System.EventHandler(this.botao_buscaProduto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Valor);
            this.groupBox1.Controls.Add(this.botao_AddProd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_NomeProd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 129);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // textBox_Valor
            // 
            this.textBox_Valor.DecimalPlaces = 2;
            this.textBox_Valor.Location = new System.Drawing.Point(368, 22);
            this.textBox_Valor.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.textBox_Valor.Name = "textBox_Valor";
            this.textBox_Valor.Size = new System.Drawing.Size(86, 23);
            this.textBox_Valor.TabIndex = 17;
            // 
            // botao_AddProd
            // 
            this.botao_AddProd.Location = new System.Drawing.Point(34, 72);
            this.botao_AddProd.Name = "botao_AddProd";
            this.botao_AddProd.Size = new System.Drawing.Size(115, 38);
            this.botao_AddProd.TabIndex = 16;
            this.botao_AddProd.Text = "Adicionar Produto";
            this.botao_AddProd.UseVisualStyleBackColor = true;
            this.botao_AddProd.Click += new System.EventHandler(this.botao_AddProd_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Valor:";
            // 
            // textBox_NomeProd
            // 
            this.textBox_NomeProd.Location = new System.Drawing.Point(88, 22);
            this.textBox_NomeProd.Name = "textBox_NomeProd";
            this.textBox_NomeProd.Size = new System.Drawing.Size(222, 23);
            this.textBox_NomeProd.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Produto:";
            // 
            // frm_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 490);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botao_buscaProduto);
            this.Controls.Add(this.botao_Voltar);
            this.Controls.Add(this.grid_Produto);
            this.Controls.Add(this.botao_ExcluirProd);
            this.Name = "frm_Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.grid_Produto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_Valor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button botao_ExcluirProd;
        private DataGridView grid_Produto;
        private Button botao_Voltar;
        private Button botao_buscaProduto;
        private GroupBox groupBox1;
        private NumericUpDown textBox_Valor;
        private Button botao_AddProd;
        private Label label2;
        private TextBox textBox_NomeProd;
        private Label label1;
    }
}