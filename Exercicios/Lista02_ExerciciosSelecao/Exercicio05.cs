/*5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” 
se a média das duas notas for maior ou igual a 7,0. 

Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final,
é a média entre a nota do exame e a média das 2 notas. 
Se esta média final for maior ou igual a 5,0, o programa deve escrever “Aprovado”, caso contrário deve 
escrever “Reprovado”.*/

internal partial class Exercicio05
{
    private static void Main(string[] args)
    {
        float nota1, nota2, media;
        string op = "S";
        while (op != "N")
        {
            Console.WriteLine("---------NOTAS---------");
            Console.WriteLine("Informe a 1ª nota: ");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a 2ª nota: ");
            nota2 = float.Parse(Console.ReadLine());

            media = (nota1 + nota2) / 2;

            if (media < 7)
            {
                Console.WriteLine("-------------EXAME-----------");
                Console.WriteLine("Digite a 1ª Nota do Exame: ");
                nota1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite a 2ª Nota do Exame: ");
                nota2 = float.Parse(Console.ReadLine());
                float mediaFinal = ((nota1 + nota2) / 2 + media) / 3;
                if (mediaFinal < 5)
                {
                    Console.WriteLine("REPROVADO");
                }
                else
                    Console.WriteLine("APROVADO");
            }
            else { Console.WriteLine("APROVADO"); }

            Console.WriteLine("Deseja continuar? (S/N)");
            op = Console.ReadLine();
        }
    }
}