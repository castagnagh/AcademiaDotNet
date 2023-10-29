/*
 10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
O programa deve mostrar os dados do atleta mais novo e mais alto.
*/
internal class Exercicio10
{
    private static void Main(string[] args)
    {
        string nome1, nome2;
        int idade1, idade2;
        double altura1, altura2;

        Console.WriteLine("Informe o nome do primeiro atleta: ");
        nome1 = Console.ReadLine();

        Console.WriteLine("Informe a idade do primeiro atleta: ");
        idade1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe a altura do primeiro atleta: ");
        altura1 = double.Parse(Console.ReadLine());

        Console.WriteLine("-----------------------------------------");

        Console.WriteLine("Informe o nome do segundo atleta: ");
        nome2 = Console.ReadLine();

        Console.WriteLine("Informe a idade do segundo atleta: ");
        idade2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe a altura do segundo atleta: ");
        altura2 = double.Parse(Console.ReadLine());

        if (altura1 > altura2)
        {
            Console.WriteLine("O atleta 1: " + nome1 + " é maior que o atleta 2: " + nome2);
        }
        else
            Console.WriteLine("O atleta 2: " + nome2 + " é maior que o atleta 1: " + nome1);
        if (idade1 > idade2)
        {
            Console.WriteLine("O atleta 1: " + nome1 + " é mais velho que o atleta 2: " + nome2);
        }
        else
            Console.WriteLine("O atleta 2: " + nome2 + " é mais velho que o atleta 1: " + nome1);
    }
}