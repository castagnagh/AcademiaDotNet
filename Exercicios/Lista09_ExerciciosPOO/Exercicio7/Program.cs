/*7 - Crie uma classe chamada Música que contenha os atributos nome, autor e gravadora. 
 * Após, crie uma classe Playlist que possua como atributo uma Lista de músicas e uma string para armazenar o dono da playlist. 
 * Implemente um método para adicionar músicas na lista, 
 * para "tocar a música" (só mostrar uma mensagem na tela com o titulo da música). 
 * Tente fazer uma reprodução aleatória, ou seja, em vez de percorrer do inicio ao fim da lista, faça um random para acessar valores aleatórios válidos.*/

//FALTA TERMINAR
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Playlist minhaPlaylist = new Playlist("x");

            while (true)
            {
                Console.WriteLine("1 - Adicionar Música");
                Console.WriteLine("2 - Tocar Música Aleatória");
                Console.WriteLine("3 - Sair");
                Console.Write("Opção: ");
                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        AdicionarMusica(minhaPlaylist);
                        break;
                    case "2":
                        TocarMusicaRandom(minhaPlaylist);
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

        static void TocarMusicaRandom(Playlist playlist)
        {
            Console.Clear();
            string musicaSelecionada = playlist.EscolherMusica();
            Console.WriteLine("Música selecionada aleatoriamente: " + musicaSelecionada);
        }

        static void AdicionarMusica(Playlist playlist)
        {
            Console.WriteLine("Informe o nome da música: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o nome do autor: ");
            string autor = Console.ReadLine();
            Console.WriteLine("Informe o nome da gravadora: ");
            string gravadora = Console.ReadLine();

            Console.WriteLine("Digite o dono da playlist: ");
            string dono = Console.ReadLine();
            Musica musica = new Musica(nome, autor, gravadora);
            Playlist pl = new Playlist(dono);
            playlist.AdicionarMusica(musica);

            Console.WriteLine("Música adicionada à playlist.");
        }
    }
}