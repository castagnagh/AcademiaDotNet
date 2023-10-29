
/*7) Crie uma função que determine se um número é primo ou não.*/
namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número: ");
            int numero = int.Parse(Console.ReadLine());
            verificaNumeroPrimo(numero);
        }

        private static void verificaNumeroPrimo(int x)
        {
            int cont = 0;
            for (int i = 1; i < x; i++)
            {
                if (x % i == 0)
                {
                    cont++;
                }
                if (cont <= 2)
                {
                    Console.WriteLine("O número é um número primo!");
                    break;
                } else
                {
                    Console.WriteLine("O numero não é primo!");
                    break;
                }
            }
        }
    }
}