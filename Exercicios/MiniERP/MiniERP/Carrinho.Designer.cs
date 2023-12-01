namespace MiniERP
{
    partial class Carrinho
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
            listView1 = new ListView();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            id = new ColumnHeader();
            nome = new ColumnHeader();
            qtd = new ColumnHeader();
            precoUnico = new ColumnHeader();
            precoTotal = new ColumnHeader();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { id, nome, qtd, precoUnico, precoTotal });
            listView1.ImeMode = ImeMode.NoControl;
            listView1.Location = new Point(36, 44);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(464, 342);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 26);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 1;
            label1.Text = "Itens selecionados:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Location = new Point(382, 392);
            button1.Name = "button1";
            button1.Size = new Size(118, 23);
            button1.TabIndex = 2;
            button1.Text = "Finalizar Compra";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Salmon;
            button2.Location = new Point(250, 392);
            button2.Name = "button2";
            button2.Size = new Size(126, 23);
            button2.TabIndex = 3;
            button2.Text = "Cancelar Compra";
            button2.UseVisualStyleBackColor = false;
            // 
            // id
            // 
            id.Text = "Cod";
            // 
            // nome
            // 
            nome.Text = "Produto";
            nome.Width = 150;
            // 
            // qtd
            // 
            qtd.Text = "Quantidade";
            // 
            // precoUnico
            // 
            precoUnico.Text = "Preço Unitário";
            precoUnico.Width = 100;
            // 
            // precoTotal
            // 
            precoTotal.Text = "Preço Total";
            precoTotal.Width = 100;
            // 
            // Carrinho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "Carrinho";
            Text = "Carrinho";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label label1;
        private Button button1;
        private ColumnHeader id;
        private ColumnHeader nome;
        private ColumnHeader qtd;
        private ColumnHeader precoUnico;
        private ColumnHeader precoTotal;
        private Button button2;
    }
}