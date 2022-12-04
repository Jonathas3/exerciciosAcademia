using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frm_Desafio2_Atos.Classes;

namespace frm_Desafio2_Atos
{
    public partial class frm_Produto : Form
    {
        public frm_Produto()
        {
            InitializeComponent();
            carregarListaProd();
        }
        private string conec = "Data Source=localhost;Initial Catalog=db_sistema;" + "User ID=usuario; password=senha; language=Portuguese";
        private void carregarListaProd()
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            dt = bd.executaConsulta("select * from Produto");
            grid_Produto.DataSource = dt;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botao_Voltar_Click(object sender, EventArgs e)
        {
            frm_Principal frm_inicio = new frm_Principal();
            frm_inicio.Show();
            this.Hide();
        }

        private void botao_buscaProduto_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            dt = bd.executaConsulta("select * from Produto");
            grid_Produto.DataSource = dt;
        }

        private void grid_Produto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botao_ExcluirProd_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();

            if (grid_Produto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Informe um Produto para excluir.");
            }
            else
            {
                p.id = int.Parse(grid_Produto.Rows[grid_Produto.SelectedRows[0].Index].Cells[0].Value.ToString());

                if (p.deletar())
                {
                    MessageBox.Show("Produto deletado com sucesso!");

                    Banco bd = new Banco();
                    DataTable dt = new DataTable();
                    dt = bd.executaConsulta("select * from Produto");
                    grid_Produto.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Erro ao deletar o Produto.");
                }
            }
        }

        private void botao_AddProd_Click_1(object sender, EventArgs e)
        {
            Produto p = new Produto();
            p.nome = textBox_NomeProd.Text;
            p.valor = textBox_Valor.Value;

            if (String.IsNullOrEmpty(p.nome))
            {
                MessageBox.Show("É necessário informar um produto para ser cadastrado.");
            }
            else
            {
                if (p.gravar())
                {
                    MessageBox.Show("Produto e preço cadastrados!");

                    Banco bd = new Banco();
                    DataTable dt = new DataTable();
                    dt = bd.executaConsulta("select * from Produto");
                    grid_Produto.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar o produto.");
                }
            }
        }
    }
    
}
