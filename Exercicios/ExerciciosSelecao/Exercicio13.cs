/*
 * 13 - Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa no VS que calcule 
seu peso ideal, utilizando as seguintes fórmulas:
Para homens: (72.7 * h) - 58
Para mulheres: (62.1 * h) - 44.7
*/
internal class Exercicio13
{
    private static void Main(string[] args)
    {
        string sexo;
        double h = 0, ideal = 0;

        Console.WriteLine("Informe seu sexo (M/F): ");
        sexo = Console.ReadLine();
        Console.WriteLine("Informe sua altura: ");
        h = double.Parse(Console.ReadLine());

        if (sexo == "M")
        {
            ideal = 72.7 * h - 58;
        }
        else if (sexo == "F")
        {
            ideal = 62.1 * h - 44.7;
        }
        else
        {
            Console.WriteLine("Valor não corresponde às opções");
        }

        Console.WriteLine("Seu peso ideal é: " + ideal.ToString("F2"));
    }
}