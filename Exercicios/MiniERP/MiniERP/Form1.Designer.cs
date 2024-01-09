namespace MiniERP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlProdutos = new TabControl();
            tabPageCompras = new TabPage();
            buttonRemoverNomePesquisaAreaitens = new Button();
            label19 = new Label();
            textBoxIdHiddenCliente = new TextBox();
            label18 = new Label();
            dataGridViewItens = new DataGridView();
            buttonAddCarrinho = new Button();
            label2 = new Label();
            buttonPesquisarAreaItensCliente = new Button();
            textBoxPesquisaCliente = new TextBox();
            label1 = new Label();
            tabPageClientes = new TabPage();
            dataGridViewClientes = new DataGridView();
            label6 = new Label();
            buttonExcluirCliente = new Button();
            panel1 = new Panel();
            maskedTextBoxCpf = new MaskedTextBox();
            button2 = new Button();
            textBoxNomeCliente = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tabPageFornecedores = new TabPage();
            dataGridViewFornecedores = new DataGridView();
            label10 = new Label();
            label9 = new Label();
            button5 = new Button();
            panel2 = new Panel();
            maskedTextBoxCnpj = new MaskedTextBox();
            buttonCadastrarFornecedor = new Button();
            textBoxNomeFornecedor = new TextBox();
            label7 = new Label();
            label8 = new Label();
            tabPageProdutos = new TabPage();
            dataGridViewProdutos = new DataGridView();
            label16 = new Label();
            panel3 = new Panel();
            button4 = new Button();
            textBoxIdFornecedor = new TextBox();
            textBoxFornecedor = new TextBox();
            label17 = new Label();
            button6 = new Button();
            textBoxEstoqueProduto = new TextBox();
            textBoxPrecoProduto = new TextBox();
            textBoxDescrProduto = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            button7 = new Button();
            label15 = new Label();
            tabControlProdutos.SuspendLayout();
            tabPageCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItens).BeginInit();
            tabPageClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            panel1.SuspendLayout();
            tabPageFornecedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFornecedores).BeginInit();
            panel2.SuspendLayout();
            tabPageProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlProdutos
            // 
            tabControlProdutos.Controls.Add(tabPageCompras);
            tabControlProdutos.Controls.Add(tabPageClientes);
            tabControlProdutos.Controls.Add(tabPageFornecedores);
            tabControlProdutos.Controls.Add(tabPageProdutos);
            tabControlProdutos.Location = new Point(12, 12);
            tabControlProdutos.Name = "tabControlProdutos";
            tabControlProdutos.SelectedIndex = 0;
            tabControlProdutos.Size = new Size(933, 525);
            tabControlProdutos.TabIndex = 2;
            // 
            // tabPageCompras
            // 
            tabPageCompras.Controls.Add(buttonRemoverNomePesquisaAreaitens);
            tabPageCompras.Controls.Add(label19);
            tabPageCompras.Controls.Add(textBoxIdHiddenCliente);
            tabPageCompras.Controls.Add(label18);
            tabPageCompras.Controls.Add(dataGridViewItens);
            tabPageCompras.Controls.Add(buttonAddCarrinho);
            tabPageCompras.Controls.Add(label2);
            tabPageCompras.Controls.Add(buttonPesquisarAreaItensCliente);
            tabPageCompras.Controls.Add(textBoxPesquisaCliente);
            tabPageCompras.Controls.Add(label1);
            tabPageCompras.Location = new Point(4, 24);
            tabPageCompras.Name = "tabPageCompras";
            tabPageCompras.Padding = new Padding(3);
            tabPageCompras.Size = new Size(925, 497);
            tabPageCompras.TabIndex = 0;
            tabPageCompras.Text = "Área de Compras";
            tabPageCompras.UseVisualStyleBackColor = true;
            // 
            // buttonRemoverNomePesquisaAreaitens
            // 
            buttonRemoverNomePesquisaAreaitens.Location = new Point(510, 66);
            buttonRemoverNomePesquisaAreaitens.Name = "buttonRemoverNomePesquisaAreaitens";
            buttonRemoverNomePesquisaAreaitens.Size = new Size(116, 23);
            buttonRemoverNomePesquisaAreaitens.TabIndex = 10;
            buttonRemoverNomePesquisaAreaitens.Text = "Remover Cliente";
            buttonRemoverNomePesquisaAreaitens.UseVisualStyleBackColor = true;
            buttonRemoverNomePesquisaAreaitens.Visible = false;
            buttonRemoverNomePesquisaAreaitens.Click += buttonRemoverNomePesquisaAreaitens_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(425, 19);
            label19.Name = "label19";
            label19.Size = new Size(62, 15);
            label19.TabIndex = 9;
            label19.Text = "Id Hidden:";
            label19.Visible = false;
            // 
            // textBoxIdHiddenCliente
            // 
            textBoxIdHiddenCliente.Enabled = false;
            textBoxIdHiddenCliente.Location = new Point(493, 15);
            textBoxIdHiddenCliente.Name = "textBoxIdHiddenCliente";
            textBoxIdHiddenCliente.Size = new Size(38, 23);
            textBoxIdHiddenCliente.TabIndex = 8;
            textBoxIdHiddenCliente.Visible = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(38, 13);
            label18.Name = "label18";
            label18.Size = new Size(319, 21);
            label18.TabIndex = 7;
            label18.Text = "Selecione o cliente que irá realizar a compra!";
            // 
            // dataGridViewItens
            // 
            dataGridViewItens.AllowUserToAddRows = false;
            dataGridViewItens.AllowUserToDeleteRows = false;
            dataGridViewItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItens.Cursor = Cursors.Hand;
            dataGridViewItens.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewItens.Location = new Point(39, 141);
            dataGridViewItens.MultiSelect = false;
            dataGridViewItens.Name = "dataGridViewItens";
            dataGridViewItens.ReadOnly = true;
            dataGridViewItens.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewItens.Size = new Size(448, 272);
            dataGridViewItens.TabIndex = 6;
            // 
            // buttonAddCarrinho
            // 
            buttonAddCarrinho.Location = new Point(333, 419);
            buttonAddCarrinho.Name = "buttonAddCarrinho";
            buttonAddCarrinho.Size = new Size(154, 23);
            buttonAddCarrinho.TabIndex = 5;
            buttonAddCarrinho.Text = "Adicionar ao Carrinho";
            buttonAddCarrinho.UseVisualStyleBackColor = true;
            buttonAddCarrinho.Click += buttonAddCarrinho_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 112);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 4;
            label2.Text = "Itens a Venda";
            // 
            // buttonPesquisarAreaItensCliente
            // 
            buttonPesquisarAreaItensCliente.Location = new Point(429, 66);
            buttonPesquisarAreaItensCliente.Name = "buttonPesquisarAreaItensCliente";
            buttonPesquisarAreaItensCliente.Size = new Size(75, 23);
            buttonPesquisarAreaItensCliente.TabIndex = 2;
            buttonPesquisarAreaItensCliente.Text = "Pesquisar";
            buttonPesquisarAreaItensCliente.UseVisualStyleBackColor = true;
            buttonPesquisarAreaItensCliente.Click += buttonPesquisarCliente_Click;
            // 
            // textBoxPesquisaCliente
            // 
            textBoxPesquisaCliente.Location = new Point(39, 66);
            textBoxPesquisaCliente.Name = "textBoxPesquisaCliente";
            textBoxPesquisaCliente.Size = new Size(384, 23);
            textBoxPesquisaCliente.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 48);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome do cliente:";
            // 
            // tabPageClientes
            // 
            tabPageClientes.Controls.Add(dataGridViewClientes);
            tabPageClientes.Controls.Add(label6);
            tabPageClientes.Controls.Add(buttonExcluirCliente);
            tabPageClientes.Controls.Add(panel1);
            tabPageClientes.Controls.Add(label5);
            tabPageClientes.Location = new Point(4, 24);
            tabPageClientes.Name = "tabPageClientes";
            tabPageClientes.Padding = new Padding(3);
            tabPageClientes.Size = new Size(925, 497);
            tabPageClientes.TabIndex = 1;
            tabPageClientes.Text = "Clientes";
            tabPageClientes.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.AllowUserToAddRows = false;
            dataGridViewClientes.AllowUserToDeleteRows = false;
            dataGridViewClientes.Cursor = Cursors.Hand;
            dataGridViewClientes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewClientes.Location = new Point(90, 213);
            dataGridViewClientes.MultiSelect = false;
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.ReadOnly = true;
            dataGridViewClientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewClientes.RowTemplate.Height = 25;
            dataGridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClientes.Size = new Size(776, 233);
            dataGridViewClientes.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(88, 28);
            label6.Name = "label6";
            label6.Size = new Size(125, 15);
            label6.TabIndex = 6;
            label6.Text = "Cadastrar novo cliente";
            // 
            // buttonExcluirCliente
            // 
            buttonExcluirCliente.Location = new Point(791, 452);
            buttonExcluirCliente.Name = "buttonExcluirCliente";
            buttonExcluirCliente.Size = new Size(75, 23);
            buttonExcluirCliente.TabIndex = 5;
            buttonExcluirCliente.Text = "Excluir";
            buttonExcluirCliente.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(maskedTextBoxCpf);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(textBoxNomeCliente);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(88, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(778, 111);
            panel1.TabIndex = 3;
            // 
            // maskedTextBoxCpf
            // 
            maskedTextBoxCpf.Location = new Point(401, 50);
            maskedTextBoxCpf.Mask = "00000000000";
            maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            maskedTextBoxCpf.Size = new Size(355, 23);
            maskedTextBoxCpf.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(681, 79);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Cadastrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += cadastrarCliente_Click;
            // 
            // textBoxNomeCliente
            // 
            textBoxNomeCliente.Location = new Point(20, 50);
            textBoxNomeCliente.Name = "textBoxNomeCliente";
            textBoxNomeCliente.Size = new Size(355, 23);
            textBoxNomeCliente.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 29);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 0;
            label3.Text = "Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(401, 29);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 1;
            label4.Text = "CPF:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 191);
            label5.Name = "label5";
            label5.Size = new Size(115, 15);
            label5.TabIndex = 2;
            label5.Text = "Clientes cadastrados";
            // 
            // tabPageFornecedores
            // 
            tabPageFornecedores.Controls.Add(dataGridViewFornecedores);
            tabPageFornecedores.Controls.Add(label10);
            tabPageFornecedores.Controls.Add(label9);
            tabPageFornecedores.Controls.Add(button5);
            tabPageFornecedores.Controls.Add(panel2);
            tabPageFornecedores.Location = new Point(4, 24);
            tabPageFornecedores.Name = "tabPageFornecedores";
            tabPageFornecedores.Size = new Size(925, 497);
            tabPageFornecedores.TabIndex = 2;
            tabPageFornecedores.Text = "Fornecedores";
            tabPageFornecedores.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFornecedores
            // 
            dataGridViewFornecedores.AllowUserToAddRows = false;
            dataGridViewFornecedores.AllowUserToDeleteRows = false;
            dataGridViewFornecedores.Cursor = Cursors.Hand;
            dataGridViewFornecedores.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewFornecedores.Location = new Point(88, 209);
            dataGridViewFornecedores.MultiSelect = false;
            dataGridViewFornecedores.Name = "dataGridViewFornecedores";
            dataGridViewFornecedores.ReadOnly = true;
            dataGridViewFornecedores.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewFornecedores.RowTemplate.Height = 25;
            dataGridViewFornecedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFornecedores.Size = new Size(766, 227);
            dataGridViewFornecedores.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(88, 191);
            label10.Name = "label10";
            label10.Size = new Size(144, 15);
            label10.TabIndex = 4;
            label10.Text = "Fornecedores cadastrados";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(88, 28);
            label9.Name = "label9";
            label9.Size = new Size(148, 15);
            label9.TabIndex = 3;
            label9.Text = "Cadastrar novo fornecedor";
            // 
            // button5
            // 
            button5.Location = new Point(779, 442);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 1;
            button5.Text = "Excluir";
            button5.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(maskedTextBoxCnpj);
            panel2.Controls.Add(buttonCadastrarFornecedor);
            panel2.Controls.Add(textBoxNomeFornecedor);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(88, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(766, 121);
            panel2.TabIndex = 0;
            // 
            // maskedTextBoxCnpj
            // 
            maskedTextBoxCnpj.Location = new Point(397, 50);
            maskedTextBoxCnpj.Mask = "00000000000000";
            maskedTextBoxCnpj.Name = "maskedTextBoxCnpj";
            maskedTextBoxCnpj.Size = new Size(353, 23);
            maskedTextBoxCnpj.TabIndex = 6;
            // 
            // buttonCadastrarFornecedor
            // 
            buttonCadastrarFornecedor.Location = new Point(675, 79);
            buttonCadastrarFornecedor.Name = "buttonCadastrarFornecedor";
            buttonCadastrarFornecedor.Size = new Size(75, 23);
            buttonCadastrarFornecedor.TabIndex = 5;
            buttonCadastrarFornecedor.Text = "Cadastrar";
            buttonCadastrarFornecedor.UseVisualStyleBackColor = true;
            buttonCadastrarFornecedor.Click += buttonCadastrarFornecedor_Click;
            // 
            // textBoxNomeFornecedor
            // 
            textBoxNomeFornecedor.Location = new Point(20, 50);
            textBoxNomeFornecedor.Name = "textBoxNomeFornecedor";
            textBoxNomeFornecedor.Size = new Size(353, 23);
            textBoxNomeFornecedor.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 32);
            label7.Name = "label7";
            label7.Size = new Size(123, 15);
            label7.TabIndex = 1;
            label7.Text = "Nome do Fornecedor:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(397, 32);
            label8.Name = "label8";
            label8.Size = new Size(37, 15);
            label8.TabIndex = 2;
            label8.Text = "CNPJ:";
            // 
            // tabPageProdutos
            // 
            tabPageProdutos.Controls.Add(dataGridViewProdutos);
            tabPageProdutos.Controls.Add(label16);
            tabPageProdutos.Controls.Add(panel3);
            tabPageProdutos.Controls.Add(button7);
            tabPageProdutos.Controls.Add(label15);
            tabPageProdutos.Location = new Point(4, 24);
            tabPageProdutos.Name = "tabPageProdutos";
            tabPageProdutos.Size = new Size(925, 497);
            tabPageProdutos.TabIndex = 3;
            tabPageProdutos.Text = "Produtos";
            tabPageProdutos.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProdutos
            // 
            dataGridViewProdutos.AllowUserToAddRows = false;
            dataGridViewProdutos.AllowUserToDeleteRows = false;
            dataGridViewProdutos.Cursor = Cursors.Hand;
            dataGridViewProdutos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewProdutos.Location = new Point(48, 244);
            dataGridViewProdutos.MultiSelect = false;
            dataGridViewProdutos.Name = "dataGridViewProdutos";
            dataGridViewProdutos.ReadOnly = true;
            dataGridViewProdutos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewProdutos.RowTemplate.Height = 25;
            dataGridViewProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProdutos.Size = new Size(814, 186);
            dataGridViewProdutos.TabIndex = 14;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(48, 16);
            label16.Name = "label16";
            label16.Size = new Size(157, 15);
            label16.TabIndex = 13;
            label16.Text = "Cadastrar um novo produto:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(button4);
            panel3.Controls.Add(textBoxIdFornecedor);
            panel3.Controls.Add(textBoxFornecedor);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(textBoxEstoqueProduto);
            panel3.Controls.Add(textBoxPrecoProduto);
            panel3.Controls.Add(textBoxDescrProduto);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Location = new Point(48, 34);
            panel3.Name = "panel3";
            panel3.Size = new Size(814, 165);
            panel3.TabIndex = 12;
            // 
            // button4
            // 
            button4.Location = new Point(699, 128);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 17;
            button4.Text = "Cadastrar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonCadastrarProduto_Click;
            // 
            // textBoxIdFornecedor
            // 
            textBoxIdFornecedor.Location = new Point(33, 100);
            textBoxIdFornecedor.Name = "textBoxIdFornecedor";
            textBoxIdFornecedor.Size = new Size(104, 23);
            textBoxIdFornecedor.TabIndex = 16;
            // 
            // textBoxFornecedor
            // 
            textBoxFornecedor.Location = new Point(163, 100);
            textBoxFornecedor.Name = "textBoxFornecedor";
            textBoxFornecedor.Size = new Size(269, 23);
            textBoxFornecedor.TabIndex = 8;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(33, 82);
            label17.Name = "label17";
            label17.Size = new Size(100, 15);
            label17.TabIndex = 15;
            label17.Text = "Id do Fornecedor:";
            // 
            // button6
            // 
            button6.Location = new Point(438, 100);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 7;
            button6.Text = "Pesquisar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonAbrirFornecedores_Click;
            // 
            // textBoxEstoqueProduto
            // 
            textBoxEstoqueProduto.Location = new Point(675, 43);
            textBoxEstoqueProduto.Name = "textBoxEstoqueProduto";
            textBoxEstoqueProduto.Size = new Size(99, 23);
            textBoxEstoqueProduto.TabIndex = 6;
            // 
            // textBoxPrecoProduto
            // 
            textBoxPrecoProduto.Location = new Point(483, 43);
            textBoxPrecoProduto.Name = "textBoxPrecoProduto";
            textBoxPrecoProduto.Size = new Size(132, 23);
            textBoxPrecoProduto.TabIndex = 5;
            // 
            // textBoxDescrProduto
            // 
            textBoxDescrProduto.Location = new Point(33, 43);
            textBoxDescrProduto.Name = "textBoxDescrProduto";
            textBoxDescrProduto.Size = new Size(399, 23);
            textBoxDescrProduto.TabIndex = 4;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(163, 82);
            label14.Name = "label14";
            label14.Size = new Size(70, 15);
            label14.TabIndex = 3;
            label14.Text = "Fornecedor:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(675, 25);
            label13.Name = "label13";
            label13.Size = new Size(52, 15);
            label13.TabIndex = 2;
            label13.Text = "Estoque:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(483, 25);
            label12.Name = "label12";
            label12.Size = new Size(40, 15);
            label12.TabIndex = 1;
            label12.Text = "Preço:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(33, 25);
            label11.Name = "label11";
            label11.Size = new Size(61, 15);
            label11.TabIndex = 0;
            label11.Text = "Descrição:";
            // 
            // button7
            // 
            button7.Location = new Point(787, 442);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 11;
            button7.Text = "Excluir";
            button7.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(48, 226);
            label15.Name = "label15";
            label15.Size = new Size(124, 15);
            label15.TabIndex = 9;
            label15.Text = "Produtos cadastrados:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 549);
            Controls.Add(tabControlProdutos);
            Name = "Form1";
            Text = "Form1";
            tabControlProdutos.ResumeLayout(false);
            tabPageCompras.ResumeLayout(false);
            tabPageCompras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItens).EndInit();
            tabPageClientes.ResumeLayout(false);
            tabPageClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPageFornecedores.ResumeLayout(false);
            tabPageFornecedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFornecedores).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPageProdutos.ResumeLayout(false);
            tabPageProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlProdutos;
        private TabPage tabPageCompras;
        private TabPage tabPageClientes;
        private TabPage tabPageFornecedores;
        private TabPage tabPageProdutos;
        private Button buttonPesquisarAreaItensCliente;
        private TextBox textBoxPesquisaCliente;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button button2;
        private TextBox textBoxCpfCliente;
        private TextBox textBoxNomeCliente;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonAddCarrinho;
        private Label label6;
        private Button buttonExcluirCliente;
        private Panel panel2;
        private TextBox textBoxNomeFornecedor;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label9;
        private Button button5;
        private Button buttonCadastrarFornecedor;
        private TextBox textBoxPrecoProduto;
        private TextBox textBoxDescrProduto;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox textBoxFornecedor;
        private Button button6;
        private TextBox textBoxEstoqueProduto;
        private Button button7;
        private Label label15;
        private Label label16;
        private Panel panel3;
        private DataGridView dataGridViewClientes;
        private MaskedTextBox maskedTextBoxCpf;
        private MaskedTextBox maskedTextBoxCnpj;
        private DataGridView dataGridViewFornecedores;
        private DataGridView dataGridViewProdutos;
        private TextBox textBoxIdFornecedor;
        private Label label17;
        private Button button4;
        private Label label18;
        private DataGridView dataGridViewItens;
        private TextBox textBoxIdHiddenCliente;
        private Label label19;
        private Button buttonRemoverNomePesquisaAreaitens;
    }
}