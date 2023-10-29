/*1 - Crie uma classe Produto com atributos como nome, preço e quantidade em estoque. 
 * Implemente um construtor e métodos para adicionar e remover itens do estoque.
 
2 - Crie uma classe RegistroDeCompras com atributos para registrar informações de compras (data, produto, valor). 
Implemente um construtor e métodos para adicionar e listar compras.*/
namespace Exercicio1e2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome do produto: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o valor do produto: ");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade em estoque: ");
            int qtEstoque = int.Parse(Console.ReadLine());
            Produto p = new Produto(nome, preco, qtEstoque);

            Console.WriteLine("Informe a data da compra: ");
            string dataCompra = Console.ReadLine();

            RegistroDeCompras rc = new RegistroDeCompras(dataCompra, p);



            p.AdicionarEstoque(50);
            p.AdicionarEstoque(50);

            p.RemoverEstoque(150);
            p.RemoverEstoque(100);

            rc.AdicionarRegistro(dataCompra, p);
            rc.ExibirLista();


        }
    }
}