namespace frm_Desafio2_Atos
{
    partial class frm_Fornecedores
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
            this.botao_ExcluirFornecedor = new System.Windows.Forms.Button();
            this.botao_Voltar = new System.Windows.Forms.Button();
            this.botao_buscaFornecedor = new System.Windows.Forms.Button();
            this.grid_MostraFornecedores = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.botao_CadFornecedor = new System.Windows.Forms.Button();
            this.grid_Produto = new System.Windows.Forms.DataGridView();
            this.textBox_Fornecedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_MostraFornecedores)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Produto)).BeginInit();
            this.SuspendLayout();
            // 
            // botao_ExcluirFornecedor
            // 
            this.botao_ExcluirFornecedor.Location = new System.Drawing.Point(492, 267);
            this.botao_ExcluirFornecedor.Name = "botao_ExcluirFornecedor";
            this.botao_ExcluirFornecedor.Size = new System.Drawing.Size(100, 39);
            this.botao_ExcluirFornecedor.TabIndex = 6;
            this.botao_ExcluirFornecedor.Text = "Excluir";
            this.botao_ExcluirFornecedor.UseVisualStyleBackColor = true;
            this.botao_ExcluirFornecedor.Click += new System.EventHandler(this.botao_ExcluirFornecedor_Click);
            // 
            // botao_Voltar
            // 
            this.botao_Voltar.Location = new System.Drawing.Point(615, 267);
            this.botao_Voltar.Name = "botao_Voltar";
            this.botao_Voltar.Size = new System.Drawing.Size(100, 39);
            this.botao_Voltar.TabIndex = 9;
            this.botao_Voltar.Text = "Voltar";
            this.botao_Voltar.UseVisualStyleBackColor = true;
            this.botao_Voltar.Click += new System.EventHandler(this.botao_Voltar_Click);
            // 
            // botao_buscaFornecedor
            // 
            this.botao_buscaFornecedor.Location = new System.Drawing.Point(33, 267);
            this.botao_buscaFornecedor.Name = "botao_buscaFornecedor";
            this.botao_buscaFornecedor.Size = new System.Drawing.Size(100, 39);
            this.botao_buscaFornecedor.TabIndex = 10;
            this.botao_buscaFornecedor.Text = "Consultar";
            this.botao_buscaFornecedor.UseVisualStyleBackColor = true;
            this.botao_buscaFornecedor.Click += new System.EventHandler(this.botao_buscaFornecedor_Click);
            // 
            // grid_MostraFornecedores
            // 
            this.grid_MostraFornecedores.AllowUserToAddRows = false;
            this.grid_MostraFornecedores.AllowUserToDeleteRows = false;
            this.grid_MostraFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_MostraFornecedores.Location = new System.Drawing.Point(33, 312);
            this.grid_MostraFornecedores.MultiSelect = false;
            this.grid_MostraFornecedores.Name = "grid_MostraFornecedores";
            this.grid_MostraFornecedores.ReadOnly = true;
            this.grid_MostraFornecedores.RowTemplate.Height = 25;
            this.grid_MostraFornecedores.Size = new System.Drawing.Size(682, 133);
            this.grid_MostraFornecedores.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.botao_CadFornecedor);
            this.groupBox1.Controls.Add(this.grid_Produto);
            this.groupBox1.Controls.Add(this.textBox_Fornecedor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 213);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Selecione o produto:";
            // 
            // botao_CadFornecedor
            // 
            this.botao_CadFornecedor.Location = new System.Drawing.Point(603, 33);
            this.botao_CadFornecedor.Name = "botao_CadFornecedor";
            this.botao_CadFornecedor.Size = new System.Drawing.Size(100, 39);
            this.botao_CadFornecedor.TabIndex = 15;
            this.botao_CadFornecedor.Text = "Cadastrar Fornecedor";
            this.botao_CadFornecedor.UseVisualStyleBackColor = true;
            this.botao_CadFornecedor.Click += new System.EventHandler(this.botao_CadFornecedor_Click);
            // 
            // grid_Produto
            // 
            this.grid_Produto.AllowUserToAddRows = false;
            this.grid_Produto.AllowUserToDeleteRows = false;
            this.grid_Produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Produto.Location = new System.Drawing.Point(21, 76);
            this.grid_Produto.MultiSelect = false;
            this.grid_Produto.Name = "grid_Produto";
            this.grid_Produto.ReadOnly = true;
            this.grid_Produto.RowTemplate.Height = 25;
            this.grid_Produto.Size = new System.Drawing.Size(559, 120);
            this.grid_Produto.TabIndex = 14;
            // 
            // textBox_Fornecedor
            // 
            this.textBox_Fornecedor.Location = new System.Drawing.Point(97, 22);
            this.textBox_Fornecedor.Name = "textBox_Fornecedor";
            this.textBox_Fornecedor.Size = new System.Drawing.Size(353, 23);
            this.textBox_Fornecedor.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fornecedor:";
            // 
            // frm_Fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 490);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grid_MostraFornecedores);
            this.Controls.Add(this.botao_buscaFornecedor);
            this.Controls.Add(this.botao_Voltar);
            this.Controls.Add(this.botao_ExcluirFornecedor);
            this.Name = "frm_Fornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedores";
            ((System.ComponentModel.ISupportInitialize)(this.grid_MostraFornecedores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Produto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button botao_ExcluirFornecedor;
        private Button botao_Voltar;
        private Button botao_buscaFornecedor;
        private DataGridView grid_MostraFornecedores;
        private GroupBox groupBox1;
        private Label label2;
        private Button botao_CadFornecedor;
        private DataGridView grid_Produto;
        private TextBox textBox_Fornecedor;
        private Label label1;
    }
}