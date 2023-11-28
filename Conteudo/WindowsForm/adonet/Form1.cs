using System.Data;

namespace adonet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Pessoa p = new Pessoa();

            if (String.IsNullOrEmpty(textBox1.Text))
            {
                dt = p.buscaPessoas();
            }
            else
            {
                p.id = int.Parse(textBox1.Text);
                //p = p.buscaPessoaByIdDR();
                //MessageBox.Show(p.nome);
                dt = p.buscaPessoaById();
            }
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = textBoxNome.Text;
            p.idade = int.Parse(textBoxIdade.Text);

            if (p.gravar())
            {
                MessageBox.Show("Cadastrado com sucesso!");
                button1_Click(null, null);
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar!");

            }
        }
    }
}