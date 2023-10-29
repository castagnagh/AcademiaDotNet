using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1e2
{
    internal class RegistroDeCompras
    {
        private List<RegistroDeCompras> registroDeCompras = new List<RegistroDeCompras>();

        public string data;
        Produto produto;

        public RegistroDeCompras(string data, Produto produto)
        {
            this.data = data;
            this.produto = produto;
        }

        public void AdicionarRegistro(string data, Produto produto)
        {

            RegistroDeCompras novoRegistro = new RegistroDeCompras(data, produto);
            registroDeCompras.Add(novoRegistro);
        }

        public void ExibirLista()
        {
            foreach (RegistroDeCompras rc in registroDeCompras)
            {
                Console.WriteLine("Produto: " + rc.produto.nome + " Valor:" + rc.produto.preco + " Quantidade em Estoque:" + rc.produto.qtEstoque + " Data de inclusão: " + rc.data);
            }
        }
    }


}
