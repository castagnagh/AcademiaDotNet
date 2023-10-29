/*2) Fazer programa que tenha duas funções. 
 * i) para ler um vetor de 10 elementos (variável global) 
 * e ii) para verificar e apresentar a quantidade de elementos pares que este vetor possui.*/

namespace Exercicio2
{
    internal class Program
    {
        static int[] vetor = new int[10];
        static void Main(string[] args)
        {
            LerVetor();
            verificaPar();
        }

        static void LerVetor()
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Informe o valor do vetor na posição " + i + ": ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }
        private static void verificaPar()
        {
            int par = 0, impar = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    par++;

                }
                else
                {
                    impar++;
                }
            }
            Console.WriteLine("Quantidade de Par: " + par);
            Console.WriteLine("Quantidade de Impar: " + impar);
        }
    }
}