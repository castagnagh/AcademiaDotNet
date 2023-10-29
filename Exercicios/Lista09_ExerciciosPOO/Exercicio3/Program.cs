/*
3 - Crie uma classe CorretoraDeImóveis com atributos para armazenar informações sobre imóveis (endereço, preço, tipo). 
Implemente um construtor e métodos para listar imóveis disponíveis e calcular o valor médio.
Crie um menu que contenha as opções de inserir imoveis, alterar preço do imovel e apresentar todos os imoveis. 
Insira os imoveis numa lista para facilitar o trabalho.*/
using System;
using Exercicio3;

class Program
{
    static void Main(string[] args)
    {
        int escolha = 0;
        Console.WriteLine("Informe a quantidade de imóveis a serem cadastrados: ");
        int qt = int.Parse(Console.ReadLine());

        CorretoraDeImoveis ci = new CorretoraDeImoveis();

        do
        {
            Console.WriteLine();
            Console.WriteLine("1 - Inserir imóveis");
            Console.WriteLine("2 - Alterar preço do imovel");
            Console.WriteLine("3 - Apresentar todos os imóveis");
            Console.WriteLine("4 - Sair");
            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    for (int i = 0; i < qt; i++)
                    {
                        Console.WriteLine("Informe o endereço do imóvel " + i + ": ");
                        string endereco = Console.ReadLine();
                        Console.WriteLine("Informe o valor do imóvel " + i + ": ");
                        double valor = double.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o tipo de imóvel " + i + ": ");
                        string tipo = Console.ReadLine();

                        ci.InserirImovel(new CorretoraDeImoveis(endereco, valor, tipo));
                    }
                    break;
                case 2:
                    ci.ExibirPrecoMedioImovel();

                    break;
                case 3:
                    ci.ListarImovel();
                    break;
                case 4:
                    Console.WriteLine("Encerrando o programa...");
                    break;
                default:
                    Console.WriteLine("Opção de escolha não existe!");
                    break;
            }
        } while (escolha != 4);
    }
}
