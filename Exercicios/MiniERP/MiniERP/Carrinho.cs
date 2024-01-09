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
    public partial class Carrinho : Form
    {
        
        public Carrinho()
        {
            InitializeComponent();
        }

        public void AtualizarCarrinho(List<RegistroCompra> lista)
        {
            foreach (var itemCompra in lista)
            {
                string[] itens = { itemCompra.PrecoTotal.ToString(), itemCompra.IdProdutos.ToString(), itemCompra.IdClientes.ToString() };
                listView1.Items.Add(new ListViewItem(itens));
            }
        }

        
    }
}
