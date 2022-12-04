namespace frm_Desafio2_Atos
{
    partial class frm_Vendas
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
            this.grid_MostraCliente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botao_Voltar = new System.Windows.Forms.Button();
            this.botao_GeraVenda = new System.Windows.Forms.Button();
            this.botao_Consulta = new System.Windows.Forms.Button();
            this.botao_ExcluirVendas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_qtd = new System.Windows.Forms.NumericUpDown();
            this.grid_MostraProd = new System.Windows.Forms.DataGridView();
            this.grid_Vendas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_MostraCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_qtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_MostraProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Vendas)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_MostraCliente
            // 
            this.grid_MostraCliente.AllowUserToAddRows = false;
            this.grid_MostraCliente.AllowUserToDeleteRows = false;
            this.grid_MostraCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_MostraCliente.Location = new System.Drawing.Point(6, 66);
            this.grid_MostraCliente.Name = "grid_MostraCliente";
            this.grid_MostraCliente.ReadOnly = true;
            this.grid_MostraCliente.RowTemplate.Height = 25;
            this.grid_MostraCliente.Size = new System.Drawing.Size(349, 111);
            this.grid_MostraCliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione o Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selecione ao produto:";
            // 
            // botao_Voltar
            // 
            this.botao_Voltar.Location = new System.Drawing.Point(639, 440);
            this.botao_Voltar.Name = "botao_Voltar";
            this.botao_Voltar.Size = new System.Drawing.Size(103, 38);
            this.botao_Voltar.TabIndex = 4;
            this.botao_Voltar.Text = "Cancelar";
            this.botao_Voltar.UseVisualStyleBackColor = true;
            this.botao_Voltar.Click += new System.EventHandler(this.botao_Voltar_Click);
            // 
            // botao_GeraVenda
            // 
            this.botao_GeraVenda.Location = new System.Drawing.Point(6, 192);
            this.botao_GeraVenda.Name = "botao_GeraVenda";
            this.botao_GeraVenda.Size = new System.Drawing.Size(104, 39);
            this.botao_GeraVenda.TabIndex = 5;
            this.botao_GeraVenda.Text = "Gerar venda";
            this.botao_GeraVenda.UseVisualStyleBackColor = true;
            this.botao_GeraVenda.Click += new System.EventHandler(this.botao_GeraVenda_Click);
            // 
            // botao_Consulta
            // 
            this.botao_Consulta.Location = new System.Drawing.Point(12, 251);
            this.botao_Consulta.Name = "botao_Consulta";
            this.botao_Consulta.Size = new System.Drawing.Size(104, 47);
            this.botao_Consulta.TabIndex = 6;
            this.botao_Consulta.Text = "Consulta";
            this.botao_Consulta.UseVisualStyleBackColor = true;
            this.botao_Consulta.Click += new System.EventHandler(this.botao_Consulta_Click);
            // 
            // botao_ExcluirVendas
            // 
            this.botao_ExcluirVendas.Location = new System.Drawing.Point(642, 259);
            this.botao_ExcluirVendas.Name = "botao_ExcluirVendas";
            this.botao_ExcluirVendas.Size = new System.Drawing.Size(100, 39);
            this.botao_ExcluirVendas.TabIndex = 8;
            this.botao_ExcluirVendas.Text = "Excluir";
            this.botao_ExcluirVendas.UseVisualStyleBackColor = true;
            this.botao_ExcluirVendas.Click += new System.EventHandler(this.botao_ExcluirVendas_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Selecione o Cliente:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_qtd);
            this.groupBox1.Controls.Add(this.grid_MostraProd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.grid_MostraCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.botao_GeraVenda);
            this.groupBox1.Location = new System.Drawing.Point(5, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 243);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Quantidade:";
            // 
            // textBox_qtd
            // 
            this.textBox_qtd.Location = new System.Drawing.Point(465, 192);
            this.textBox_qtd.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.textBox_qtd.Name = "textBox_qtd";
            this.textBox_qtd.Size = new System.Drawing.Size(86, 23);
            this.textBox_qtd.TabIndex = 18;
            // 
            // grid_MostraProd
            // 
            this.grid_MostraProd.AllowUserToAddRows = false;
            this.grid_MostraProd.AllowUserToDeleteRows = false;
            this.grid_MostraProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_MostraProd.Location = new System.Drawing.Point(387, 66);
            this.grid_MostraProd.Name = "grid_MostraProd";
            this.grid_MostraProd.ReadOnly = true;
            this.grid_MostraProd.RowTemplate.Height = 25;
            this.grid_MostraProd.Size = new System.Drawing.Size(349, 111);
            this.grid_MostraProd.TabIndex = 10;
            // 
            // grid_Vendas
            // 
            this.grid_Vendas.AllowUserToAddRows = false;
            this.grid_Vendas.AllowUserToDeleteRows = false;
            this.grid_Vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Vendas.Location = new System.Drawing.Point(12, 313);
            this.grid_Vendas.Name = "grid_Vendas";
            this.grid_Vendas.ReadOnly = true;
            this.grid_Vendas.RowTemplate.Height = 25;
            this.grid_Vendas.Size = new System.Drawing.Size(730, 111);
            this.grid_Vendas.TabIndex = 11;
            // 
            // frm_Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 490);
            this.Controls.Add(this.grid_Vendas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botao_ExcluirVendas);
            this.Controls.Add(this.botao_Consulta);
            this.Controls.Add(this.botao_Voltar);
            this.Name = "frm_Vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.grid_MostraCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_qtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_MostraProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Vendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grid_MostraCliente;
        private Label label1;
        private Label label2;
        private Button botao_Voltar;
        private Button botao_GeraVenda;
        private Button botao_Consulta;
        private Button botao_ExcluirVendas;
        private Label label3;
        private GroupBox groupBox1;
        private DataGridView grid_MostraProd;
        private DataGridView grid_Vendas;
        private Label label4;
        private NumericUpDown textBox_qtd;
    }
}