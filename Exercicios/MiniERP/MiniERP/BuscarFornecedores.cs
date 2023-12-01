using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP
{
    public partial class BuscarFornecedores : Form
    {
        DataTable dt = new DataTable();
        Fornecedor fornecedor = new Fornecedor();

        private int _idLinha;
        private string _nomeLinha;

        public int IdLinha { get; private set; }
        public string NomeLinha { get; private set; }
        public BuscarFornecedores()
        {
            InitializeComponent();
            //preencher os dados dos fornecedores no datagrid
            dt = fornecedor.BuscaFornecedores();
            dataGridView1.DataSource = dt;
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = dataGridView1.SelectedRows[0];

                IdLinha = (int)linha.Cells["id"].Value;
                NomeLinha = (string)linha.Cells["nome"].FormattedValue;

                this.Close();
            }
        }

        private void buscarFornecedor(object sender, KeyEventArgs e)
        {
            fornecedor.Nome = textBox1.Text;
            dt = fornecedor.BuscaFornecedoresByNome();
            dataGridView1.DataSource = dt;
        }
    }
}
