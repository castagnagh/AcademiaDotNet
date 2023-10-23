/*5) Desenvolva uma função que converta uma temperatura em graus Celsius para Fahrenheit.*/
namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a temperatura em Graus Celsius? ");
            int celsius = int.Parse(Console.ReadLine());
            ConverterTemperatura(celsius);
        }

        static void ConverterTemperatura(int celsius)
        {
            double f = (celsius * 9 / 5) + 32;
            Console.WriteLine("A temperatura em Fahrenheit é " + f);
        }
    }
}