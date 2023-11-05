/*10 - Crie uma classe chamada Animal que tenha as propriedades Nome, Especie e Idade. 
 * Crie também um método chamado EmitirSom, que imprime na tela o som do animal.*/
namespace Exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string op = "";
            Animal animal = new Animal();
            do
            {
                Console.WriteLine("Emitir som de: ");
                Console.WriteLine("1 - Gato");
                Console.WriteLine("2 - Cachorro");
                Console.WriteLine("3 - Ovelha");
                Console.WriteLine("4 - Vaca");
                Console.WriteLine("5 - Sair");
                Console.WriteLine("Opção: ");
                op = Console.ReadLine();
                animal.EmitirSom(op);
            } while (op != "5");
        }
    }
}