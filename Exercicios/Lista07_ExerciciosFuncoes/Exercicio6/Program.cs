/*6) Escreva uma função que calcule a média de um vetor de 10 números.*/
namespace Exercicio6
{
    internal class Program
    {
        static void Main()
        {
            double[] numeros = new double[10];
            
            double media = CalcularMedia(numeros);

            Console.WriteLine("A média dos números é: " + media);
        }

        static double CalcularMedia(double[] numeros)
        {
            double soma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }

            double media = soma / numeros.Length;
            return media;
        }

    }
}