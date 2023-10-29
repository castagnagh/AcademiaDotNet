/*20 - Escreva um algoritmo para o jogo de adivinhação do número secreto. O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
plus: você pode gerar o número de forma randomica (função random c#).
*/
internal class Exercicio20
{
    private static void Main(string[] args)
    {
        int num = 0, numRand = 0;

        Random rand = new Random();
        numRand = rand.Next(0, 99);
        Console.WriteLine("TENTE ADIVINHAR O NUMERO INTEIRO DE 0 A 100 (3 chances)");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Informe o número inteiro: ");
            num = int.Parse(Console.ReadLine());
            if (num == numRand)
            {
                Console.WriteLine("Você acertou!!!");
            }
            else if (num > numRand)
            {
                Console.WriteLine("Errou! O número que você digitou é maior!");
            }
            else if (num < numRand)
            {
                Console.WriteLine("Errou! O número que você digitou é menor!");
            }
        }
        Console.WriteLine("Acabou, número sorteado: " + numRand);
    }
}