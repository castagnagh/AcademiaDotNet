namespace MiniERP
{
    partial class BuscarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            dataGridViewBuscaClientes = new DataGridView();
            buttonSelecionarBuscaCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuscaClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 30);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "Buscar por nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 99);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 1;
            label2.Text = "Clientes cadastrados:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(424, 23);
            textBox1.TabIndex = 2;
            textBox1.KeyUp += buscarClientes;
            // 
            // dataGridViewBuscaClientes
            // 
            dataGridViewBuscaClientes.AllowUserToAddRows = false;
            dataGridViewBuscaClientes.AllowUserToDeleteRows = false;
            dataGridViewBuscaClientes.Cursor = Cursors.Hand;
            dataGridViewBuscaClientes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewBuscaClientes.Location = new Point(50, 117);
            dataGridViewBuscaClientes.MultiSelect = false;
            dataGridViewBuscaClientes.Name = "dataGridViewBuscaClientes";
            dataGridViewBuscaClientes.ReadOnly = true;
            dataGridViewBuscaClientes.RowTemplate.Height = 25;
            dataGridViewBuscaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBuscaClientes.Size = new Size(424, 271);
            dataGridViewBuscaClientes.TabIndex = 3;
            // 
            // buttonSelecionarBuscaCliente
            // 
            buttonSelecionarBuscaCliente.Location = new Point(399, 403);
            buttonSelecionarBuscaCliente.Name = "buttonSelecionarBuscaCliente";
            buttonSelecionarBuscaCliente.Size = new Size(75, 23);
            buttonSelecionarBuscaCliente.TabIndex = 4;
            buttonSelecionarBuscaCliente.Text = "Selecionar";
            buttonSelecionarBuscaCliente.UseVisualStyleBackColor = true;
            buttonSelecionarBuscaCliente.Click += buttonSelecionarBuscaCliente_Click;
            // 
            // BuscarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 450);
            Controls.Add(buttonSelecionarBuscaCliente);
            Controls.Add(dataGridViewBuscaClientes);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BuscarCliente";
            Text = "BuscarCliente";
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuscaClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private DataGridView dataGridViewBuscaClientes;
        private Button buttonSelecionarBuscaCliente;
    }
}