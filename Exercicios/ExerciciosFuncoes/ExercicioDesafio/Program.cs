/*Desafio: Ler um vetor de inteiros com 10 elementos e passar por parâmetro para uma função que verifica e retorna o menor elemento do vetor.*/
namespace ExercicioDesafio
{
    internal class Program
    {
        static void Main()
        {
            int[] numeros = new int[10];

            for(int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Informe o número: ");
                numeros[i] = int.Parse(Console.ReadLine());

            }
            

            Console.WriteLine("O menor dos números é: " + verificaMenor(numeros));
        }

        static int verificaMenor(int[] numeros)
        {
            int menor = numeros[0];

            for (int i = 0; i < numeros.Length; i++)
            {
                if(numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }
            return menor;
        }
    }
}