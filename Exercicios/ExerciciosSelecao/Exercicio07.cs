/*7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por 
exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.
*/

internal partial class Exercicio07
{
    private static void Main(string[] args)
    {
        string frase, palavra;
        Console.WriteLine("Digite uma frase: ");
        frase = Console.ReadLine();
        Console.WriteLine("Agora digte uma palavra para buscar na frase: ");
        palavra = Console.ReadLine();

        if (frase.Contains(palavra) == true)
            Console.WriteLine("A palavra encontra-se na frase");
        else
            Console.WriteLine("A palavra não se encontra na frase");
    }
}