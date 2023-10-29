/*6 - Utilize o exercício 1 para criar uma lista de produtos e faça métodos para apresentar na tela e para consultar produtos pelo código.*/
using System;
using System.Collections.Generic;

namespace Exercicio6
{
    internal class Program
    {
        static Produto prod = new Produto();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1 - Adicionar Produto e Qtd no Estoque");
                Console.WriteLine("2 - Consultar Produto por ID");
                Console.WriteLine("3 - Remover Produto do Estoque");
                Console.WriteLine("4 - Listar Produtos");
                Console.WriteLine("5 - Sair");
                Console.WriteLine("Opção: ");
                string op = Console.ReadLine();
                switch (op)
                {
                    case "1":
                        AdicionarProduto();
                        break;
                    case "2":
                        ConsultarProdutoPorId();
                        break;
                    case "3":
                        RemoverEstoque();
                        break;
                    case "4":
                        ListarProdutos();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }

        static void AdicionarProduto()
        {
            Console.Clear();
            Console.WriteLine("Informe o Código (ID) do produto: ");
            string codId = Console.ReadLine();
            Console.WriteLine("Informe o nome do produto: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o valor do produto: ");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade em estoque: ");
            int qtEstoque = int.Parse(Console.ReadLine());
            Produto produto = new Produto(codId, nome, preco, qtEstoque);

            if (prod.AdicionarProduto(produto))
            {
                Console.WriteLine("Produto adicionado com sucesso!");
            }
            else
            {
                Console.WriteLine("Produto com o mesmo ID já existe.");
            }
        }

        static void ConsultarProdutoPorId()
        {
            Console.Clear();
            Console.WriteLine("Informe o Código (ID) para consulta do produto: ");
            string codId = Console.ReadLine();
            Produto produto = prod.ConsultarProdutoPorId(codId);

            if (produto != null)
            {
                Console.WriteLine("Listando Produto: ");
                Console.WriteLine("Id: " + produto.Id);
                Console.WriteLine("Descrição: " + produto.nome);
                Console.WriteLine("Preço: " + produto.preco);
                Console.WriteLine("Quantidade de estoque: " + produto.qtEstoque);
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }

        static void RemoverEstoque()
        {
            Console.Clear();
            Console.WriteLine("Informe o código do produto para remover quantidade do estoque: ");
            string codId = Console.ReadLine();
            Console.WriteLine("Informe a quantidade a ser removida do estoque: ");
            int qtd = int.Parse(Console.ReadLine());

            if (prod.RemoverEstoque(codId, qtd))
            {
                Console.WriteLine("Estoque atualizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Não foi possível remover o estoque.");
            }
        }

        static void ListarProdutos()
        {
            Console.Clear();
            prod.ListarProdutos();
        }
    }
}