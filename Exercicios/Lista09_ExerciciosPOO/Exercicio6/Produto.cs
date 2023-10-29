using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    internal class Produto
    {
        static List<Produto> listaProdutos = new List<Produto>();

        public string Id { get; set; }
        public string nome;
        public double preco;
        public int qtEstoque;

        public Produto(string id, string nome, double preco, int qtEstoque)
        {
            Id = id;
            this.nome = nome;
            this.preco = preco;
            this.qtEstoque = qtEstoque;
        }

        public Produto()
        {
        }

        public bool AdicionarProduto(Produto produto)
        {
            foreach (var p in listaProdutos)
            {
                if (p.Id == produto.Id)
                {
                    return false;
                }
            }
            listaProdutos.Add(produto);
            return true;
        }

        public Produto ConsultarProdutoPorId(string id)
        {
            foreach (var produto in listaProdutos)
            {
                if (produto.Id == id)
                {
                    return produto;
                }
            }
            return null;
        }

        public bool RemoverEstoque(string id, int quantidade)
        {
            foreach (var produto in listaProdutos)
            {
                if (produto.Id == id)
                {
                    if (quantidade > 0 && quantidade <= produto.qtEstoque)
                    {
                        produto.qtEstoque -= quantidade;
                        return true;
                    }
                }
            }
            return false;
        }

        public void ListarProdutos()
        {
            int i = 0;
            foreach (var produto in listaProdutos)
            {
                Console.WriteLine(" ------------ PRODUTO " + i + " -----------------");
                Console.WriteLine("Id: " + produto.Id);
                Console.WriteLine("Descrição: " + produto.nome);
                Console.WriteLine("Preço: " + produto.preco);
                Console.WriteLine("Quantidade de estoque: " + produto.qtEstoque);
                i++;
            }
        }
    }
}
