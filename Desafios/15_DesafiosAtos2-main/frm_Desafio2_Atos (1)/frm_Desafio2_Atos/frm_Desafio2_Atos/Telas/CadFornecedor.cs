using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frm_Desafio2_Atos.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace frm_Desafio2_Atos
{
    public partial class frm_Fornecedores : Form
    {
        public frm_Fornecedores()
        {
            InitializeComponent();
            carregarListaProd();
            carregarListaForn();
        }
        private void carregarListaProd()
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            dt = bd.executaConsulta("select * from Produto");
            grid_Produto.DataSource = dt;
        }

        private void carregarListaForn()
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            dt = bd.executaConsulta("select * from Fornecedor");
            grid_MostraFornecedores.DataSource = dt;
        }

        private string conec = "Data Source=localhost;Initial Catalog=db_sistema;" + "User ID=usuario; password=senha; language=Portuguese";
        private void botao_Voltar_Click(object sender, EventArgs e)
        {
            frm_Principal frm_inicio = new frm_Principal();
            frm_inicio.Show();
            this.Hide();
        }
        private void textBox_Fornecedor_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void botao_buscaFornecedor_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            dt = bd.executaConsulta("select * from Fornecedor");
            grid_MostraFornecedores.DataSource = dt;
        }

        private void botao_ExcluirFornecedor_Click(object sender, EventArgs e)
        {
            Fornecedor forn = new Fornecedor();

            if (grid_MostraFornecedores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Informe um Fornecedor para excluir.");
            }
            else
            {
                forn.id = int.Parse(grid_MostraFornecedores.Rows[grid_MostraFornecedores.SelectedRows[0].Index].Cells[0].Value.ToString());

                if (forn.deletar())
                {
                    MessageBox.Show("Fornecedor deletado com sucesso!");

                    Banco bd = new Banco();
                    DataTable dt = new DataTable();
                    dt = bd.executaConsulta("select * from Fornecedor");
                    grid_MostraFornecedores.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Erro ao deletar o Fornecedor.");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botao_CadFornecedor_Click(object sender, EventArgs e)
        {
            Fornecedor forn = new Fornecedor();
            forn.nome = textBox_Fornecedor.Text;
            //var i = grid_Fornecedor.SelectedRows[0].Index.ToString();

            if (String.IsNullOrEmpty(forn.nome))
            {
                MessageBox.Show("É necessário informar um fornecedor para ser cadastrado.");
            }
            else
            {
                if (grid_Produto.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Informe um produto para associar.");
                }
                else
                {
                    forn.produto_id = int.Parse(grid_Produto.Rows[ grid_Produto.SelectedRows[0].Index].Cells[0].Value.ToString());

                    if (forn.gravar())
                    {
                        MessageBox.Show("Fornecedor cadastrado!");

                        Banco bd = new Banco();
                        DataTable dt = new DataTable();
                        dt = bd.executaConsulta("select * from Fornecedor");
                        grid_MostraFornecedores.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar o Fornecedor.");
                    }
                }
            }
        }
    }
}

