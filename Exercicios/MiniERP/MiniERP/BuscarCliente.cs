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
    public partial class BuscarCliente : Form
    {
        private int _idCliente;
        private string _nome;

        public int IdCliente { get; private set; }
        public string Nome { get; private set; }

        Cliente cli = new Cliente();
        DataTable dt = new DataTable();
        public BuscarCliente()
        {
            InitializeComponent();
            dt = cli.BuscaClientes();
            dataGridViewBuscaClientes.DataSource = dt;
        }

        //keyPressUp
        private void buscarClientes(object sender, KeyEventArgs e)
        {
            cli.Nome = textBox1.Text;
            dt = cli.BuscaClientesByNome();
            dataGridViewBuscaClientes.DataSource = dt;

        }

        private void buttonSelecionarBuscaCliente_Click(object sender, EventArgs e)
        {
            if (dataGridViewBuscaClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = dataGridViewBuscaClientes.SelectedRows[0];

                IdCliente = (int)linha.Cells["id"].Value;
                Nome = (string)linha.Cells["nome"].FormattedValue;

                this.Close();
            }
        }
    }
}
