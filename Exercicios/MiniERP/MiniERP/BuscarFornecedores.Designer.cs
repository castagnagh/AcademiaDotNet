namespace MiniERP
{
    partial class BuscarFornecedores
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            buttonSelecionar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Cursor = Cursors.Hand;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.ImeMode = ImeMode.NoControl;
            dataGridView1.Location = new Point(12, 121);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(429, 218);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 103);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 1;
            label1.Text = "Selecione o fornecedor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 23);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 2;
            label2.Text = "Digite para buscar:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(429, 23);
            textBox1.TabIndex = 3;
            textBox1.KeyUp += buscarFornecedor;
            // 
            // buttonSelecionar
            // 
            buttonSelecionar.Location = new Point(366, 374);
            buttonSelecionar.Name = "buttonSelecionar";
            buttonSelecionar.Size = new Size(75, 23);
            buttonSelecionar.TabIndex = 4;
            buttonSelecionar.Text = "Selecionar";
            buttonSelecionar.UseVisualStyleBackColor = true;
            buttonSelecionar.Click += buttonSelecionar_Click;
            // 
            // BuscarFornecedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 418);
            Controls.Add(buttonSelecionar);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "BuscarFornecedores";
            Text = "BuscarFornecedores";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button buttonSelecionar;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnCnpj;
    }
}