using System.Data;

namespace MiniERP
{
    public partial class Form1 : Form
    {
        Cliente cli = new Cliente();
        Fornecedor fornecedor = new Fornecedor();
        Produto produto = new Produto();
        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
            //otimizar isso
            //preencher os dados dos clientes no datagrid
            DataTable dt = new DataTable();
            dt = cli.BuscaClientes();
            dataGridViewClientes.DataSource = dt;

            //preencher os dados dos fornecedores no datagrid
            DataTable dtFor = new DataTable();
            dtFor = fornecedor.BuscaFornecedores();
            dataGridViewFornecedores.DataSource = dtFor;

            //preencher os dados dos produtos no datagrid
            dt = produto.BuscaProdutos();
            dataGridViewProdutos.DataSource = dt;

            //preencher os dados dos Itens no datagrid
            dt = produto.BuscaItens();
            dataGridViewItens.DataSource = dt;

            //desativar o campo Id Fornecedor na Aba Produtos
            textBoxIdFornecedor.Enabled = false;
            textBoxFornecedor.Enabled = false;

            //DESATIVA O CAMPO Pesquisa cliente até ser selecionado um cliente
            textBoxPesquisaCliente.Enabled = false;
            //desativa o datagridview até ser selecionado um cliente
            dataGridViewItens.Visible = false;
            //desativa o button do add carrinho até ser selecionado o cliente
            buttonAddCarrinho.Visible = false;

        }

        //dar mais uma atenção a isso para não ter redundancia no código, talvez criar uma interface? com método para atualizar datagrid
        //private void AtualizarDadosTabela()
        //{

        //}
        //CLIENTES
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
        //FORNECEDORES
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

        //PRODUTOS
        private void buttonCadastrarProduto_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(textBoxDescrProduto.Text) ||
                String.IsNullOrEmpty(textBoxPrecoProduto.Text) ||
                String.IsNullOrEmpty(textBoxEstoqueProduto.Text) ||
                String.IsNullOrEmpty(textBoxIdFornecedor.Text))
            {
                MessageBox.Show("Há campos em branco, preencha-os e tente novamente!");
            }
            else
            {
                produto.Nome = textBoxDescrProduto.Text;
                produto.Preco = float.Parse(textBoxPrecoProduto.Text);
                produto.QntEstoque = int.Parse(textBoxEstoqueProduto.Text);
                produto.IdFornecedor = int.Parse(textBoxIdFornecedor.Text);
                if (produto.Gravar())
                {
                    MessageBox.Show("Cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK);
                    //atualiza dados na tabela
                    dt = produto.BuscaProdutos();
                    dataGridViewProdutos.DataSource = dt;

                    textBoxDescrProduto.Text = "";
                    textBoxPrecoProduto.Text = "";
                    textBoxEstoqueProduto.Text = "";
                    textBoxIdFornecedor.Text = "";
                    textBoxFornecedor.Text = "";
                    textBoxDescrProduto.Focus();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar!");
                }

            }
        }

        private void buttonAbrirFornecedores_Click(object sender, EventArgs e)
        {
            BuscarFornecedores bf = new BuscarFornecedores();
            bf.ShowDialog();

            int idSelecionado = bf.IdLinha;
            string nomeSelecionado = bf.NomeLinha;
            if (String.IsNullOrEmpty(idSelecionado.ToString()) || String.IsNullOrEmpty(nomeSelecionado))
            {
                MessageBox.Show("Você não selecionou nenhum fornecedor!", "Aviso");
            }
            else
            {
                textBoxIdFornecedor.Text = idSelecionado.ToString();
                textBoxFornecedor.Text = nomeSelecionado.ToString();
            }
        }

        private void buttonPesquisarCliente_Click(object sender, EventArgs e)
        {

            BuscarCliente bc = new BuscarCliente();
            bc.ShowDialog();

            int idSelecionado = bc.IdCliente;
            string nomeSelecionado = bc.Nome;

            if (String.IsNullOrEmpty(idSelecionado.ToString()) || String.IsNullOrEmpty(nomeSelecionado))
            {
                MessageBox.Show("Você não selecionou nenhum cliente", "Aviso");
            }
            else
            {
                textBoxPesquisaCliente.Text = nomeSelecionado;
                textBoxIdHiddenCliente.Text = idSelecionado.ToString();
                dataGridViewItens.Visible = true;
                buttonAddCarrinho.Visible = true;
                buttonPesquisarAreaItensCliente.Enabled = false;
                buttonRemoverNomePesquisaAreaitens.Visible = true;
            }
        }

        //função feita para caso o usuario já tiver selecionado um cliente, mas depois clicar para selecionar novamente
        //e nesse momento não selecionar ninguem, então
        private void LimparCampos()
        {
            textBoxPesquisaCliente.Text = "";
            dataGridViewItens.Visible = false;
            buttonAddCarrinho.Visible = false;

        }

        private void buttonRemoverNomePesquisaAreaitens_Click(object sender, EventArgs e)
        {
            LimparCampos();
            buttonPesquisarAreaItensCliente.Enabled = true;
            buttonRemoverNomePesquisaAreaitens.Visible = false;
        }

        public int count = 0;
        private void buttonAddCarrinho_Click(object sender, EventArgs e)
        {
            Carrinho c = new Carrinho();

            if (count == 0)
            {
                c.Show();
                count++;
                AdicionarAoCarrinho();
            }
            else
            {
                AdicionarAoCarrinho();
            }
            

            
        }

        private void AdicionarAoCarrinho()
        {
            RegistroCompra rc = new RegistroCompra();
            Carrinho c = new Carrinho();

            if (dataGridViewItens.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = dataGridViewItens.SelectedRows[0];
                //cells[0] é o id do produto
                int idProduto = (int)linha.Cells["Cod"].Value;
                //cells[2] é onde esta localizado o preço
                float preco = (float)linha.Cells["Preço"].Value;
                //e no textIdHidden é onde esta o Id do cliente selecionado
                int idCliente = int.Parse(textBoxIdHiddenCliente.Text);

                rc.addLista(preco, idCliente, idProduto);

                c.AtualizarCarrinho(rc.listaItensTemp);
                this.Close();
            }
        }
    }
}