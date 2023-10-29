/*
 9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:

Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.
Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for 
menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média for maior que
150, avisá-lo que será necessário adicionar 2 unidades de insulina.
*/
internal class Exercicio09
{
    private static void Main(string[] args)
    {
        int valor1, valor2, valor3;
        double media;

        Console.WriteLine("Entre com o primeiro valor: ");
        valor1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Entre com o segundo valor: ");
        valor2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Entre com o terceiro valor: ");
        valor3 = int.Parse(Console.ReadLine());

        media = (valor1 + valor2 + valor3) / 3;

        if (valor1 < 65 || valor2 < 65 || valor3 < 65)
        {
            Console.WriteLine("Você corre risco de hipoglicemia");
            if (media < 80)
            {
                Console.WriteLine("Sua média foi menor que 80, será necessário diminuir 2 unidades de insulina");
            }
        }
        else if (valor1 > 250 || valor2 > 250 || valor3 > 250)
        {
            Console.WriteLine("Você corre risco de hiperglicemia");
            if (media > 150)
            {
                Console.WriteLine("Sua média foi maior que 150, você precisará adicionar 2 unidades de insulina");
            }
        }
        else
            Console.WriteLine("Está OK");
    }
}