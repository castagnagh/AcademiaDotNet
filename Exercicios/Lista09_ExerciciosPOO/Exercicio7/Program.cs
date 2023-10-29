/*7 - Crie uma classe chamada Música que contenha os atributos nome, autor e gravadora. 
 * Após, crie uma classe Playlist que possua como atributo uma Lista de músicas e uma string para armazenar o dono da playlist. 
 * Implemente um método para adicionar músicas na lista, 
 * para "tocar a música" (só mostrar uma mensagem na tela com o titulo da música). 
 * Tente fazer uma reprodução aleatória, ou seja, em vez de percorrer do inicio ao fim da lista, faça um random para acessar valores aleatórios válidos.*/
namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1 - Adicionar Música");
                Console.WriteLine("2 - Tocar Música Aleaória");
                Console.WriteLine("3 - Sair");
                Console.Write("Opção: ");
                string op = Console.ReadLine();

                switch(op)
                {
                    case "1":
                        AdicionarMusica();
                        break;
                    case "2":
                        TocarMusicaRandom();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }

        private static void TocarMusicaRandom()
        {
            throw new NotImplementedException();
        }

        static void AdicionarMusica()
        {
            Console.WriteLine("Informe o nome da música: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o nome do autor: ");
            string autor = Console.ReadLine();
            Console.WriteLine("Informe o nome da gravadora: ");
            string gravadora = Console.ReadLine();
            Console.WriteLine("Quem é o dono da playlist? ");
            string dono = Console.ReadLine();

            Musica musica = new Musica(nome, autor, gravadora);
            Playlist playlist = new Playlist(dono);
            playlist.AdicionarMusica(musica);

            Console.WriteLine("Música adicionada à playlist.");
        }
    }
}