/*
 * 8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.
Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.
E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do 
total de vendas. 
*/

internal partial class Exercicio08
{
    private static void Main(string[] args)
    {
        int cod;
        string nome;
        double salarioBase, totalVendas, salarioFinal;

        Console.WriteLine("Digite o código do funcionário: ");
        cod = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o nome do funcionário: ");
        nome = Console.ReadLine();
        Console.WriteLine("Digite o salário base do funcionário: ");
        salarioBase = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o total de vendas R$: ");
        totalVendas = double.Parse(Console.ReadLine());

        if (totalVendas >= 5000)
        {
            salarioFinal = totalVendas * 1.10;
        }
        else if (totalVendas >= 1000)
        {
            salarioFinal = totalVendas * 1.07;
        }
        else if (totalVendas >= 500)
        {
            salarioFinal = totalVendas * 1.05;
        }
        else
        {
            salarioFinal = totalVendas;
        }

        Console.WriteLine("Código: " + cod);
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Salário Base: " + salarioBase);
        Console.WriteLine("Total de vendas: R$ " + totalVendas);
        Console.WriteLine("-------Atualização de Salário-------");
        Console.WriteLine("Salário Reajustado: " + salarioFinal + salarioBase);
    }
}