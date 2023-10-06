

using System.Runtime.Serialization;
using System.Xml;

namespace ExerciciosRepeticao
{
    internal class Exercicio01
    {
        static void Main(string[] args)
        {
            //            /*1. Escreva um algoritmo para ler um número n, e em seguida ler pelo teclado a idade de n 
            //pessoas e calcular a média das idades.*/
            //            int soma = 0;
            //            Console.WriteLine("Informe quantas pessoas você gostaria de calcular a média das idades: ");
            //            int n = int.Parse(Console.ReadLine());

            //            for (int i = 1; i <= n; i++)
            //            {
            //                Console.WriteLine("Digite a idade da " + i + "º pessoa: ");
            //                int idade = int.Parse(Console.ReadLine());

            //               soma += idade;                
            //            }

            //            Console.WriteLine("A média das idades é: " + soma/n);

            /* 2. Faça um algoritmo que leia 10 números pelo teclado, e que no final mostre o maior deles. Não usar vetor.*/

            //int maior = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("Informe o " + i + " número: ");
            //    int num = int.Parse(Console.ReadLine());

            //    if(num > maior)
            //    {
            //        maior = num;
            //    }
            //}
            //Console.WriteLine("O maior dos números é: " + maior);

            /*3. Escreva um algoritmo que leia pelo teclado um valor e então calcule a tabuada de 1 a 10 de um número
            x lido utilizando laços de repetição, e mostre na tela.*/

            //Console.WriteLine("Informe o número para ver sua tabuada: ");
            //int num = int.Parse(Console.ReadLine());

            //for(int i = 0; i <= 10; i++)
            //    Console.WriteLine(i + "x" + num + " = " + num*i);
            //{

            //}

            /*4. Escreva um algoritmo que leia dois valores pelo teclado, x e y, e em seguida calcule a potência de x
            elevado na y sem utilizar a função pow.*/
            //int resultado = 1;
            //Console.Write("Informe o valor de X: ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("Informe o valor de Y: ");
            //int y = int.Parse(Console.ReadLine());

            //for(int i = 0; i < y; i++)
            //{
            //    resultado *= x;
            //}
            //Console.Write("Resultado: " + resultado);

            /*5. Escreva um algoritmo para calcular o fatorial de um número.*/
            //int resultado = 1;
            //Console.Write("Digite um número para calcular o seu fatorial: ");
            //int num = int.Parse(Console.ReadLine());

            //for(int i = 1; i <= num; i++)
            //{
            //    resultado *= i;
            //}
            //Console.WriteLine("O fatorial de " + num + " é " + resultado);

            /*6. Escreva um algoritmo que leia o número de alunos de uma turma e em seguida leia a quantidade de avaliações 
            aplicadas para aquela turma. Por fim, leia as notas das avaliações de cada aluno e mostre sua nota final 
            (média das notas das avaliações).*/

            //int qntAlunos, qntProvas;
            //double nota = 0, soma = 0, media = 0;
            //Console.WriteLine("Informe a quantidade de alunos: ");
            //qntAlunos = int.Parse(Console.ReadLine());
            //Console.WriteLine("Quantidade de avaliações aplicadas: ");
            //qntProvas = int.Parse(Console.ReadLine());

            //for(int i = 0; i < qntAlunos; i++)
            //{
            //    for(int j = 0; j < qntProvas; j++)
            //    {
            //        Console.WriteLine("Informe a nota "+j+": ");
            //        nota = double.Parse(Console.ReadLine());

            //        soma += nota;

            //        media = soma / qntProvas;
            //    }
            //    Console.WriteLine("A média destas avaliações são: " + media);
            //}

            /*7. Escreva um programa em C# leia 20 números e que conte a quantidade de números pares e ímpares digitados por 
            um usuário. Apresente o resultado.*/
            //int countPar = 0, countImpar = 0;
            //for(int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine("Informe um número: ");
            //    int num = int.Parse(Console.ReadLine());
            //    if(num % 2 == 0)
            //    {
            //        countPar++;
            //    } else
            //    {
            //        countImpar++;
            //    }
            //}
            //Console.WriteLine("Total de números Pares digitados: " + countPar);
            //Console.WriteLine("Total de números Impares digitados: " + countImpar);
        }
    }
}