/*4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora 
 * recebido por cada um deles. Mostrar na tela qual dos professores tem o maior salário total.*/

internal partial class Exercicio04
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe a quantidade de horas de horas das pelo professor 1: ");
        int horas1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor da hora: ");
        int valor1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe a quantidade de horas de horas das pelo professor 2: ");
        int horas2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor da hora: ");
        int valor2 = int.Parse(Console.ReadLine());

        int salario1 = horas1 * valor1;
        int salario2 = horas2 * valor2;

        if (salario1 > salario2)
            Console.WriteLine("O professor 1 tem o maior salário");
        if (salario2 > salario1)
            Console.WriteLine("O professor 2 tem o maior salário");
        else
            Console.WriteLine("Ambos tem o mesmo salário");
    }
}