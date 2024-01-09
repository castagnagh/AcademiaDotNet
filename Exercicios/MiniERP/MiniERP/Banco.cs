using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP
{
    internal class Banco
    {
        public string conec = @"Data Source=.\SQLEXPRESS;Initial Catalog=miniERP;User ID=usuario1;Password=senha1234";

        private SqlConnection cn;

        private void conexao()
        {
            cn = new SqlConnection(conec);
        }

        public SqlConnection AbrirConexao()
        {
            try
            {
                conexao();
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void FecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ExecutaConsulta(string sql)
        {
            try
            {
                AbrirConexao();
                SqlCommand sqlCommand = new SqlCommand(sql, cn);
                sqlCommand.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;

            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
