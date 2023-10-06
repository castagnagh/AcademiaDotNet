/*
 6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) e o 
peso (kg) de uma pessoa. O programa deve calcular o Indice de Massa Corpórea (IMC), exibi-lo ao usuário e informar 
sua situação conforme a tabela.
O cálculo do imc = peso / (altura * altura)

IMC 
menor que 18                -> baixo peso
maior que 18 e menor que 25 -> peso normal
maior que 25 e menor que 30 -> sobrepeso
maior que 30 e menor que 35 -> obesidade
maior que 35                -> obesidade grau sério
*/

internal partial class Exercicio06
{
    private static void Main(string[] args)
    {
        Console.Write("Informe seu nome: ");
        string nome = Console.ReadLine().ToUpper();

        Console.Write("Sua altura em metros: ");
        double altura = double.Parse(Console.ReadLine());

        Console.Write("Seu pso em kilos: ");
        double peso = double.Parse(Console.ReadLine());

        double imc = peso / (altura * altura);
        Console.WriteLine(nome + " seu IMC é de " + imc.ToString("0.#"));

        if (imc < 18)
        {
            Console.WriteLine("Baixo peso");
        }
        else if (imc < 25)
        {
            Console.WriteLine("Peso normal");
        }
        else if (imc < 30)
        {
            Console.WriteLine("Sobre peso");
        }
        else if (imc < 35)
        {
            Console.WriteLine("Obesidade");
        }
        else
        {
            Console.WriteLine("Obesidade grau sério");
        }
    }
}