using System.Data;

namespace MiniERP
{
    public partial class Form1 : Form
    {
        Cliente cli = new Cliente();
        Fornecedor fornecedor = new Fornecedor();
        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
            //otimizar isso
            //preencher os dados dos clientes no datagrid
            dt = cli.BuscaClientes();
            dataGridViewClientes.DataSource = dt;

            //preencher os dados dos fornecedores no datagrid
            dt = fornecedor.BuscaFornecedores();
            dataGridViewClientes.DataSource = dt;

        }

        //dar mais uma atenção a isso para não ter redundancia no código, talvez criar uma interface? com método para atualizar datagrid
        //private void AtualizarDadosTabela()
        //{

        //}
        private void cadastrarCliente_Click(object sender, EventArgs e)
        {
            cli.Nome = textBoxNomeCliente.Text;
            cli.Cpf = maskedTextBoxCpf.Text;
            if (String.IsNullOrEmpty(cli.Cpf) || String.IsNullOrEmpty(cli.Nome))
            {
                MessageBox.Show("Os campos não podem estar em brancos!", "Aviso");
            }
            else
            {
                if (cli.Gravar())
                {
                    MessageBox.Show("Cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK);
                    dt = cli.BuscaClientes();
                    dataGridViewClientes.DataSource = dt;
                    textBoxNomeCliente.Text = "";
                    maskedTextBoxCpf.Text = "";
                    textBoxNomeCliente.Focus();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar!");
                }
            }

        }

        private void buttonCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            fornecedor.Nome = textBoxNomeFornecedor.Text;
            fornecedor.Cnpj = maskedTextBoxCnpj.Text;
            if (String.IsNullOrEmpty(fornecedor.Cnpj) || String.IsNullOrEmpty(fornecedor.Nome))
            {
                MessageBox.Show("Os campos não podem estar em brancos!", "Aviso");
            }
            else
            {
                if (fornecedor.Gravar())
                {
                    MessageBox.Show("Cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK);
                    //atualiza dados na tabela
                    dt = fornecedor.BuscaFornecedores();
                    dataGridViewFornecedores.DataSource = dt;

                    textBoxNomeFornecedor.Text = "";
                    maskedTextBoxCnpj.Text = "";
                    textBoxNomeFornecedor.Focus();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar!");
                }
            }
        }
    }
}