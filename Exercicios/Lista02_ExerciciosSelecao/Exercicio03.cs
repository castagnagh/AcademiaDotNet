
/*3 - Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, e escrever na tela os 
 * que são superiores à média.*/

internal partial class Exercicio03
{
    private static void Main(string[] args)
    {
        float media;
        Console.WriteLine("Informe o 1º Número: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o 2º Número: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o 3º Número: ");
        int num3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o 4º Número: ");
        int num4 = int.Parse(Console.ReadLine());

        media = (num1 + num2 + num3 + num4) / 4;
        Console.WriteLine("A média é: " + media);
        Console.WriteLine("O número que são maiores que a média são: ");
        if (num1 > media) Console.WriteLine(num1);
        if (num2 > media) Console.WriteLine(num2);
        if (num3 > media) Console.WriteLine(num3);
        if (num4 > media) Console.WriteLine(num4);
    }
}