/*12 - Crie uma classe Agenda que pode armazenar inúmeras pessoas e que seja capaz de realizar as seguintes operações:
  void armazenaPessoa(String nome, int idade, float altura);
  void removePessoa(String nome);
  Pessoa buscaPessoa(String nome); // retorna a pessoa com o nome informado
  void imprimeAgenda(); // imprime os dados de todas as pessoas da agenda
Faça um menu para navegar entre as opções infinitamente.*/
using static System.Net.Mime.MediaTypeNames;

namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agenda a = new Agenda();
            while (true)
            {
                Console.WriteLine("--------- MENU ---------");
                Console.WriteLine("1 - Armazenar pessoa na agenda");
                Console.WriteLine("2 - Remover pessoa");
                Console.WriteLine("3 - Buscar pessoa");
                Console.WriteLine("4 - Listar agenda");
                Console.Write("Opção: ");
                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Informe o nome: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Informe a idade: ");
                        int idade = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe a atura: ");
                        double altura = double.Parse(Console.ReadLine());
                        Agenda ag = new Agenda(nome, idade, altura);
                        a.AdicionarPessoa(ag);
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Busque um nome para remover: ");
                        string removaNome = Console.ReadLine();
                        a.RemoverPorNome(removaNome);
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Informe o nome para buscar o contato: ");
                        string buscaNome = Console.ReadLine();
                        a.BuscarPorNome(buscaNome);
                        break;
                    case "4":
                        Console.Clear();
                        a.ExibirPessoa();
                        break;
                    default: Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}