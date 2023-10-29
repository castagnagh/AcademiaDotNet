/*4 - Crie uma classe AgendaTelefônica com atributos para armazenar contatos (nome, telefone, e-mail). 
Implemente um construtor e métodos para adicionar numa lista, remover e buscar contatos.*/
namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Informe o nome do contato: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Informe o número: ");
                string numero = Console.ReadLine();
                Console.WriteLine("Informe o E-Mail: ");
                string email = Console.ReadLine();
                Agenda a = new Agenda(nome, numero, email);

                a.AdicionarContato(a);
                a.ExibirContatos();

                Console.WriteLine("Informe o nome para buscar o contato: ");
                string buscaNome = Console.ReadLine();
                a.BuscarContatoPorNome(buscaNome);

                Console.WriteLine("Busque um nome para remover: ");
                string removaNome = Console.ReadLine();
                a.RemoverContatoPorNome(removaNome);

                a.ExibirContatos();
            }
        }
    }
}