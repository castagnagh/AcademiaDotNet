/*
 12 - Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e 
número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo-se que ele ganha 
R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento 
armazenando-o na variável "extra", caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00. 
No final do processamento, exibir o salário total e o salário excedente do operário.
*/
internal class Exercicio12
{
    private static void Main(string[] args)
    {
        int cod, numHoras;
        double extra = 0, salario = 0, salarioExtra = 0;
        Console.WriteLine("Informe o seu código: ");
        cod = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o numero de horas trabalhadas: ");
        numHoras = int.Parse(Console.ReadLine());
        if (numHoras > 50)
        {
            extra = numHoras - 50;
            if (extra < 0) extra = 0;
            salario = numHoras * 10;
            //extra*20 -> 20 é o valor da hora extra
            salarioExtra = salario + extra * 20;
        }
        else
            salario = numHoras * 10;
        salarioExtra = salario + extra * 20;

        Console.WriteLine("Salário: " + salario);
        Console.WriteLine("Salário Extra: " + extra * 20);
        Console.WriteLine("Salário Total (Salário + Extra): " + salarioExtra);
    }
}