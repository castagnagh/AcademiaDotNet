using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP
{
    internal class Fornecedor
    {
        private int _id;
        private string _nome;
        private string _cnpj;

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Cnpj { get => _cnpj; set => _cnpj = value; }

        public bool Gravar()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();

            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "insert into fornecedores values " +
                "(@nome, @cnpj)";
            command.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@cnpj", System.Data.SqlDbType.VarChar);
            command.Parameters[0].Value = Nome;
            command.Parameters[1].Value = Cnpj;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                bd.fecharConexao();
            }
        }

        public DataTable BuscaFornecedores()
        {
            Banco bd = new Banco();

            try
            {
                SqlConnection cn = bd.abrirConexao();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = cn;
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.CommandText = "select * from fornecedores";

                sqlCommand.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                bd.fecharConexao();
            }
        }
    }
}
