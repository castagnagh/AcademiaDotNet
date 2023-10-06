/*
 2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar. 
*/
internal partial class Exercicio02
{
    private static void Main(string[] args)
    {
        string op = "S";
        while (op != "N")
        {
            Console.WriteLine("Informe um numero: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("O numero é PAR");
            else
                Console.WriteLine("O numero é IMPAR");

            Console.WriteLine("Deseja continuar? (S/N)");
            op = Console.ReadLine();
        }
    }
}