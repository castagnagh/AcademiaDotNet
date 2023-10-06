/*1 - Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: 
Área do triangulo = (base * altura) / 2; 
Teste se a base ou a altura digitada não foi igual a zero.
*/
internal class Exercicio01
{
    private static void Main(string[] args)
    {
        float baseT, altura, area;

        Console.WriteLine("Informe a base do triangulo: ");
        baseT = float.Parse(Console.ReadLine());

        Console.WriteLine("Informe a altura do triangulo: ");
        altura = float.Parse(Console.ReadLine());
        if (baseT != 0 && altura != 0)
        {
            area = baseT * altura / 2;
            Console.WriteLine("A area do triangulo é: " + area);
        }
        else
            Console.WriteLine("A base ou a altura não pode ser igual a zero!");
    }
}