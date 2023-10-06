/*
 17 - Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), e então diga se esses lados podem ou não formar um triangulo. Para que os lados
formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados. Caso os lados formem um triangulo, diga se o mesmo é equilátero (todos
os lados iguais), isoceles (somente 2 lados são iguais) ou escaleno (os 3 lados são diferentes).
*/
internal class Exercicio17
{
    private static void Main(string[] args)
    {
        int a, b, c;

        Console.Write("Informe o lado A: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Informe o lado B: ");
        b = int.Parse(Console.ReadLine());
        Console.Write("Informe o lado C: ");
        c = int.Parse(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
        {
            Console.WriteLine("É um triangulo!");
            if (a == b && b == c)
            {
                Console.WriteLine("E equilátero, pois possui todos os lado iguais!");
            }
            else if (a == b && a != c || a == c && a != c || b == c && b != a)
            {
                Console.WriteLine("E isoceles, pois possue dois lados iguais");
            }
            else
            {
                Console.WriteLine("E Escaleno, pois possui os lados diferentes");
            }
        }
        else
        {
            Console.WriteLine("Não é um triangulo!");
        }
    }
}