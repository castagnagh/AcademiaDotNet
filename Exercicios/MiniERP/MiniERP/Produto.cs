using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP
{
    internal class Produto
    {
        private int _id;
        private string _nome;
        private float _preco;
        private int _qntEstoque;
        private int _idFornecedor;

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public float Preco { get => _preco; set => _preco = value; }
        public int QntEstoque { get => _qntEstoque; set => _qntEstoque = value; }
        public int IdFornecedor { get => _idFornecedor; set => _idFornecedor = value; }

        public bool Gravar()
        {
            //instanciar um objeto da classe Banco, pois lá estão os métodos para abrir conexão com o banco
            Banco bd = new Banco();
            //classe que representa a conexão com o SQL Server
            SqlConnection cn = bd.AbrirConexao();

            //classe que representa a transação a ser feita para confirmar ou retornar 
            SqlTransaction tran = cn.BeginTransaction();

            //classe para declarar os comandos no SQL Server
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            //declarando que o tipo do comando utilizado é text
            command.CommandType = System.Data.CommandType.Text;
            //comando text SQL para fazer a consulta com o banco
            command.CommandText = "insert into produtos values " +
                "(@nome, @preco, @qtd_estoque, @fk_fornecedor)";
            //aqui eu declaro qual os tipos dos atributos que serão passados pro comando SQL para
            //evitar SQL Injection
            command.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@preco", System.Data.SqlDbType.Float);
            command.Parameters.Add("@qtd_estoque", System.Data.SqlDbType.Int);
            command.Parameters.Add("@fk_fornecedor", System.Data.SqlDbType.Int);
            //aqui eu passo os valores
            command.Parameters[0].Value = Nome;
            command.Parameters[1].Value = Preco;
            command.Parameters[2].Value = QntEstoque;
            command.Parameters[3].Value = IdFornecedor;

            try
            {
                //executo a Query SQL
                command.ExecuteNonQuery();
                //envio a transaction
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                //se der problema retorno ao ultimo ponto
                tran.Rollback();
                return false;
            }
            finally
            {
                bd.FecharConexao();
            }
        }

        public DataTable BuscaProdutos()
        {
            Banco bd = new Banco();

            try
            {
                SqlConnection cn = bd.AbrirConexao();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = cn;
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.CommandText = "select * from produtos";

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
