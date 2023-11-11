/*8 - Crie uma classe chamada "Calculadora" com métodos para somar, subtrair, multiplicar e dividir números. 
 * Implemente sobrecargas desses métodos para aceitar diferentes números de argumentos e tipos, como inteiros e decimais.*/
using System;

namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            Console.WriteLine(calc.Somar(2.5,2.5));
            Console.WriteLine(calc.Somar(3,3));
            Console.WriteLine(calc.Multiplicar(3, 3.5));
            Console.WriteLine(calc.Multiplicar(6,6));
            Console.WriteLine(calc.Dividir(4, 16));
            Console.WriteLine(calc.Dividir(16, 4));
            Console.WriteLine(calc.Subtrair(5, 5));
            Console.WriteLine(calc.Subtrair(10.5, 0.5));
        }
    }
}