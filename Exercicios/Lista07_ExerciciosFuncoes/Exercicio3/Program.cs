namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1º Numero: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("2º Número: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("3º Numero: ");
            double num3 = double.Parse(Console.ReadLine());
            Console.WriteLine("A média dos números é: " + CalcularMedia(num1, num2, num3));
        }

        static double CalcularMedia(double a, double b, double c)
        {
            double media;

            media = (a + b + c) / 3;

            return media;
        }
    }
}