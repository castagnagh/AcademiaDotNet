/*4) Escreva uma função que calcule o fatorial de um número inteiro positivo.*/
namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número: ");
            int num = int.Parse(Console.ReadLine());
            CalcularFatorial(num);
        }

        static void CalcularFatorial(int num)
        {
            int fatorial = 1;
            for(int i = num; i >0; i--)
            {
                fatorial *= i;
            }
            Console.WriteLine("Fatorial de "+num+ " é: " + fatorial);
        }
    }
}