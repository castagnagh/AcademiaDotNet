/*8 - Crie classes chamadas Fabricante e Produto. Fabricante que tenha as propriedades Nome, Endereço e Cidade.  Produto que tenha as propriedades Nome, Fabricante (objeto da classe Fabricante) e Preco. Utilize o encapsulamento para garantir que o nome não seja vazio e que o preço seja positivo. 
*/
namespace Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            Console.WriteLine("Informe o nome do produto: ");
            produto.NomeProduto = Console.ReadLine();
            Console.WriteLine("Informe o preço do produto: ");
            produto.Valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome do fabricante do produto: ");
            produto.fabricante.Nome = Console.ReadLine();
            Console.WriteLine("Informe o endereço da fabricação: ");
            produto.fabricante.Endereco = Console.ReadLine();
            Console.WriteLine("Informe o cidade da fabricação: ");
            produto.fabricante.Cidade = Console.ReadLine();
            


        }
    }
}