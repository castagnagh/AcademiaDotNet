using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1e2
{
    internal class Produto
    {
        public string nome;
        public double preco;
        public int qtEstoque;

        public Produto(string nome, double preco, int qtEstoque)
        {
            this.nome = nome;
            this.preco = preco;
            this.qtEstoque = qtEstoque;
        }

        public void AdicionarEstoque(int quantidade)
        {
            if(quantidade > 0)
            {
                qtEstoque += quantidade;
                Console.WriteLine("Foi adicionado " + quantidade + " ao estoque!");
            } else
            {
                Console.WriteLine("O valor deve ser maior que zero!");
            }
            
        }

        public void RemoverEstoque(int quantidade)
        {
            if(quantidade > 0 && quantidade <= qtEstoque)
            {
                qtEstoque -= quantidade;
                Console.WriteLine("Foi removido " + quantidade + " ao estoque!");
            } else if(quantidade > qtEstoque)
            {
                Console.WriteLine("Não há itens suficientes para retirar");
            }
            else
            {
                Console.WriteLine("A quantidade deve ser maior que zero");
            }
        }


    }
}
