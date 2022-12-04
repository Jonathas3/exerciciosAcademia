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
    public partial class frm_Clientes : Form
    {
        public frm_Clientes()
        {
            InitializeComponent();
            carregarListaCli();
        }
        private string conec = "Data Source=localhost;Initial Catalog=db_sistema;" + "User ID=usuario; password=senha; language=Portuguese";

        private void carregarListaCli()
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            dt = bd.executaConsulta("select * from Cliente");
            grid_Cliente.DataSource = dt;
        }

        private void botao_Voltar_Click(object sender, EventArgs e)
        {
            frm_Principal frm_inicio = new frm_Principal();
            frm_inicio.Show();
            this.Hide();
        }
        private void botao_buscaCliente_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            dt = bd.executaConsulta("select * from Tbcliente");
            grid_Cliente.DataSource = dt;
        }
        private void botao_CadCliente_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.nome = textBox_NomeCliente.Text;
            if (c.gravar())
            {
                MessageBox.Show("Cliente cadastrado!");

                Banco bd = new Banco();
                DataTable dt = new DataTable();
                dt = bd.executaConsulta("select * from Cliente");
                grid_Cliente.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar o cliente.");
            }
        }

        private void btn_excluirCli_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();

            if (grid_Cliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Informe um Cliente para excluir.");
            }
            else
            {
                c.id = int.Parse(grid_Cliente.Rows[grid_Cliente.SelectedRows[0].Index].Cells[0].Value.ToString());

                if (c.deletar())
                {
                    MessageBox.Show("Cliente deletado com sucesso!");

                    Banco bd = new Banco();
                    DataTable dt = new DataTable();
                    dt = bd.executaConsulta("select * from Cliente");
                    grid_Cliente.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Erro ao deletar o Cliente.");
                }
            }
        }
    }
}
