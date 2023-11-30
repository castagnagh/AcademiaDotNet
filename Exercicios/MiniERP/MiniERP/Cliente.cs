using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP
{
    internal class Cliente
    {
        private int _id;
        private string _nome;
        private string _cpf;

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }

        public bool Gravar()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.AbrirConexao();

            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "insert into clientes values " +
                "(@nome, @cpf)";
            command.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@cpf", System.Data.SqlDbType.VarChar);
            command.Parameters[0].Value = Nome;
            command.Parameters[1].Value = Cpf;

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
                bd.FecharConexao();
            }
        }

        public DataTable BuscaClientes()
        {
            Banco bd = new Banco();

            try
            {
                SqlConnection cn = bd.AbrirConexao();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = cn;
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.CommandText = "select * from clientes";

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
                bd.FecharConexao();
            }
        }
    }
}
