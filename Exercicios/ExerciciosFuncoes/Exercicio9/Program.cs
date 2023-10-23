/*9) Escrever um programa com uma função que receba por parâmetro dois números (n1 e n2) 
 * e retorna a soma dos números inteiros que existem entre n1 e n2 (inclusive ambos). 
 * Apresente o resultado na main.*/
namespace Exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe dois numeros: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("A soma é: " + somaEntreNum(num1, num2));
        }

        private static int somaEntreNum(int num1, int num2)
        {
            int soma = 0;
            if(num1 > num2)
            {
                for (int i = num1; i <= num2; i++)
                {
                    soma += i;
                }
            } else
            {
                for (int i = num2; i <= num1; i++)
                {
                    soma += i;
                }
            }

            return soma;
        }
    }
}