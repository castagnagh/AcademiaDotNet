/*
 18 - Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.
*/
internal class Exercicio18
{
    private static void Main(string[] args)
    {
        int valor1, valor2, valor3, maior = 0;

        Console.WriteLine("Informe o primeiro valor: ");
        valor1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o segundo valor: ");
        valor2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o terceiro valor: ");
        valor3 = int.Parse(Console.ReadLine());

        if (valor1 > valor2)
        {
            maior = valor1;
        }
        if (maior > valor3)
        {
            Console.Write("O maior é: " + maior);
        }
        else if (valor2 > valor3)
        {
            Console.WriteLine("O maior é: " + valor2);
        }
        else
        {
            Console.WriteLine("O maior é: " + valor3);
        }
    }
}