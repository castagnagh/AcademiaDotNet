/*19 - Ajuste o exercício 18 de maneira que mostre os valores informados em ordem crescente.
*/
internal class Exercicio19
{
    private static void Main(string[] args)
    {
        int valor1, valor2, valor3, maior = 0, meio = 0, menor = 0;

        Console.WriteLine("Informe o primeiro valor: ");
        valor1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o segundo valor: ");
        valor2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o terceiro valor: ");
        valor3 = int.Parse(Console.ReadLine());

        if (valor1 > valor2 && valor2 > valor3)
        {
            maior = valor1;
            meio = valor2;
            menor = valor3;
        }
        else if (valor2 > valor1 & valor1 > valor3)
        {
            maior = valor2;
            meio = valor1;
            menor = valor3;
        }
        else if (valor3 > valor2 && valor2 > valor1)
        {
            maior = valor3;
            meio = valor2;
            menor = valor1;
        }
        else if (valor3 > valor1 && valor1 > valor2)
        {
            maior = valor3;
            meio = valor1;
            menor = valor2;
        }

        Console.WriteLine("Os números em ordem crescentes ficam assim: " + menor + ", " + meio + ", " + maior);
    }
}