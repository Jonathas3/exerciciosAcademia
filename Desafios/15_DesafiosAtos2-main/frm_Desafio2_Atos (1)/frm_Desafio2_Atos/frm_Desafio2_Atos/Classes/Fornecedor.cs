
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frm_Desafio2_Atos.Classes
{
    internal class Fornecedor
    {
        public int id;
        public string nome;
        public int produto_id;

        public bool gravar()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();

            SqlTransaction transacao = cn.BeginTransaction();
            SqlCommand com = new SqlCommand();
            com.Connection = cn;
            com.Transaction = transacao;
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into Fornecedor(nome, produto_id) values (@nome_fornecedor, @idProduto);";
            com.Parameters.Add("@nome_fornecedor", SqlDbType.VarChar);
            com.Parameters.Add("@idProduto", SqlDbType.Int);
            com.Parameters[0].Value = nome;
            com.Parameters[1].Value = produto_id;

            try
            {
                com.ExecuteNonQuery();
                transacao.Commit();
                return true;

            }
            catch (Exception ex)
            {
                transacao.Rollback();
                return false;

            }
            finally
            {
                bd.fecharConexao();
            }

        }

        public bool deletar()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();

            SqlTransaction transacao = cn.BeginTransaction();
            SqlCommand com = new SqlCommand();
            com.Connection = cn;
            com.Transaction = transacao;
            com.CommandType = CommandType.Text;
            com.CommandText = "delete from Fornecedor where id =  @id";
            com.Parameters.Add("@id", SqlDbType.Int);
            com.Parameters[0].Value = id;

            try
            {
                com.ExecuteNonQuery();
                transacao.Commit();
                return true;

            }
            catch (Exception ex)
            {
                transacao.Rollback();
                return false;

            }
            finally
            {
                bd.fecharConexao();
            }

        }
    }
}
