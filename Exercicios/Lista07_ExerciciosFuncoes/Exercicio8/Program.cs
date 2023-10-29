/*8) Ler um número inteiro e passar por parâmetro para uma função e retornar 0, se o número é par, ou 1, se o número é ímpar.*/
namespace Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("O retorno da função é: " + verificaParImpar(num));
        }

        private static int verificaParImpar(int num)
        {
            if(num % 2 == 0)
            {
                return 0;
            } else
            {
                return 1;
            }
        }
    }
}