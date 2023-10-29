/*
 5 - Crie uma classe GerenciadorDeTarefas com atributos para armazenar uma lista de tarefas (descrição, data de vencimento). 
Implemente um construtor e métodos para adicionar, remover e listar tarefas. 
Adicione um método para verificar se a tarefa deverá ser executada no dia de hoje. 
 */
using System;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            GerenciadorDeTarefas gt = new GerenciadorDeTarefas();
            do
            {
                Console.WriteLine("1 - Adicionar tarefa");
                Console.WriteLine("2 - Listar tarefas");
                Console.WriteLine("3 - Remover tarefa");
                Console.WriteLine("4 - Sair");
                Console.WriteLine("Opção: ");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Informe a descrição da tarefa: ");
                        string descricao = Console.ReadLine();
                        Console.WriteLine("Data de vencimento: ");
                        DateOnly data = DateOnly.Parse(Console.ReadLine());
                        gt.AdicionarTarefa(new GerenciadorDeTarefas(descricao, data));
                        break;
                    case "2":
                        Console.Clear();
                        gt.ListarTarefa();
                        gt.VerificarTarefaHoje();
                        break;
                    case "3":
                        Console.Clear();
                        gt.ListarTarefa();
                        Console.WriteLine("Escolha o número de uma tarefa para remover: ");
                        string descricaoR = Console.ReadLine();
                        gt.RemoverTarefa(descricaoR);
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }   


            } while (opcao != "4");

        }
    }
}