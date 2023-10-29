/*15 - Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados 
da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados 
e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00. 
Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.*/

internal class Exercicio15
{
    private static void Main(string[] args)
    {
        double tam, preco, qntLatas;

        Console.WriteLine("Informe o tamanho (m³): ");
        tam = double.Parse(Console.ReadLine());
        //18 LITROS PINTAM 54 METROS QUADRADOS
        //18 * 3 = 54
        qntLatas = tam / 54;
        preco = Math.Ceiling(qntLatas) * 80;

        double qntLatasReal = Math.Ceiling(qntLatas);

        Console.WriteLine("Quantidade de latas para pintar: " + qntLatasReal);
        Console.WriteLine("Preço a pagar pelas latas: " + preco + " reais");
    }
}