using System;
using System.Data;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Na teoria dos Sistemas, define-se como elemento minimax de uma matriz, o menor elemento da linha em que se encontra o maior elemento da matriz. Escreva um programa que lê uma matriz [10 X 10] e em uma função encontre e mostre o elemento minimax e sua posição na matriz.\r\n\r\n" +
                "2 - Escreva uma função chamada CalcularMedia que recebe um vetor de números, a informação se o usuário deseja escolher os pares ou os impares, e retorna a média dos valores conforme a escolha do usuário.\r\n\r\n" +
                "3 - Escreva uma função chamada TransporMatriz que recebe uma matriz como parâmetro e retorna a matriz transposta.\r\n\r\n" +
                "4 - Escreva uma função chamada MultiplicarMatrizes que recebe duas matrizes como parâmetros e retorna a matriz resultante da multiplicação.\r\n\r\n" +
                "5 - Crie uma função chamada SomaDiagonalPrincipal que recebe uma matriz quadrada como parâmetro e retorna a soma dos elementos na diagonal principal.\r\n\r\n" +
                "6 - Escreva uma função chamada MediaColunaMatriz que recebe uma matriz e um número de coluna como parâmetros, e retorna a soma dos elementos nessa coluna.\r\n\r\n" +
                "7 - Crie uma função chamada VerificarNumeroPrimo que recebe um vetor de números inteiros como parâmetro e retorna verdadeiro se pelo menos um número primo estiver presente no vetor, e falso caso contrário.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Qual exercicio deseja executar? Escolha do 1 ao 7");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                //EXERCICIO 1
                case 1:
                    int[,] matriz = new int[5, 5];

                    for (int i = 0; i < matriz.GetLength(0); i++)
                    {
                        for (int j = 0; j < matriz.GetLength(0); j++)
                        {
                            Console.Write("[" + i + "," + j + "] = ");
                            matriz[i, j] = int.Parse(Console.ReadLine());
                        }
                    }
                    MiniMax(matriz);
                    break;

                //EXERCICIO 2
                case 2:
                    Console.Clear();
                    int[] vetor = new int[5];
                    int op;
                    for (int i = 0; i < vetor.Length; i++)
                    {
                        Console.WriteLine("Informe o numero do vetor[" + i + "]: ");
                        vetor[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Você deseja calcular a média dos números Pares ou Impares?");
                    Console.WriteLine("1 - Par / 2 - Impar");
                    op = int.Parse(Console.ReadLine());
                    CalcularMedia(vetor, op);
                    break;
                //EXERCICIO 3
                case 3:
                    int[,] m = new int[3, 4];
                    Console.WriteLine("Informe os elementos da Matriz[3,4]: ");
                    for (int i = 0; i < m.GetLength(0); i++)
                    {
                        for (int j = 0; j < m.GetLength(1); j++)
                        {
                            Console.Write("[" + i + "," + j + "] = ");
                            m[i, j] = int.Parse(Console.ReadLine());
                        }
                    }
                    TransporMatriz(m);
                    break;

                //EXERCICIO 4
                case 4:
                    int[,] m1 = new int[2, 2];
                    int[,] m2 = new int[2, 2];
                    Console.WriteLine("Informe os elementos da 1ª Matriz[2,2]: ");
                    for (int i = 0; i < m1.GetLength(0); i++)
                    {
                        for (int j = 0; j < m1.GetLength(1); j++)
                        {
                            Console.WriteLine("[" + i + "," + j + "] = ");
                            m1[i, j] = int.Parse(Console.ReadLine());
                        }
                    }
                    Console.WriteLine("Informe os elementos da 2ª Matriz[2,2]: ");
                    for (int i = 0; i < m2.GetLength(0); i++)
                    {
                        for (int j = 0; j < m2.GetLength(1); j++)
                        {
                            Console.WriteLine("[" + i + "," + j + "] = ");
                            m2[i, j] = int.Parse(Console.ReadLine());
                        }
                    }
                    MultiplicarMatrizes(m1, m2);
                    break;
                //EXERCICIO 5
                case 5:
                    int[,] mat = new int[3, 3];
                    Console.WriteLine("Informe a matriz[3,3]: ");
                    for (int i = 0; i < mat.GetLength(0); i++)
                    {
                        for (int j = 0; j < mat.GetLength(1); j++)
                        {
                            Console.Write("[" + i + "," + j + "] = ");
                            mat[i, j] = int.Parse(Console.ReadLine());
                        }
                    }
                    SomaDiagonalPrincipal(mat);
                    break;
                case 6:
                    int[,] mat1 = new int[3, 3];
                    Console.WriteLine("Informe a matriz[3,3]: ");
                    for (int i = 0; i < mat1.GetLength(0); i++)
                    {
                        for (int j = 0; j < mat1.GetLength(1); j++)
                        {
                            Console.Write("[" + i + "," + j + "] = ");
                            mat1[i, j] = int.Parse(Console.ReadLine());
                        }
                    }
                    Console.WriteLine("Informe a coluna que você deseja ter a média: ");
                    int coluna = int.Parse(Console.ReadLine());
                    MediaColunaMatriz(mat1, coluna);
                    break;
                case 7:

                    break;
                default:
                    Console.WriteLine("Esse número de exercício não existe, digite um número de 1 a 7");
                    break;
            }
        }


        //----------------------------------------------------------------------------------
        //METODO PARA O EXERCICIO 1
        static void MiniMax(int[,] m)
        {
            int maior = 0;
            int menor = 0;
            int[] posicao = new int[2];
            //laço para verificar qual o maior elemento da matriz
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(0); j++)
                {
                    if (m[i, j] > maior)
                    {
                        maior = m[i, j];
                        //quando encontra o maior número armazena o indice no vetor POSICAO[0]
                        posicao[0] = i;
                        posicao[1] = j;
                    }
                }
            }
            //mostra a matriz
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(0); j++)
                {
                    Console.Write("[" + m[i, j] + "]");
                }
                Console.WriteLine();
            }
            //aqui ele procura somente na linha "posicao[0]" indice foi armazenado no vetor
            //atribuo o menor valor ao elemento da primeira posicao da linha
            menor = m[posicao[0], 0];
            for (int j = 0; j < m.GetLength(1); j++)
            {
                if (m[posicao[0], j] <= menor)
                {
                    menor = m[posicao[0], j];
                    posicao[0] = posicao[0];
                    posicao[1] = j;
                }
            }

            Console.WriteLine("Maior elemento encontrado na matriz: " + maior);
            Console.WriteLine("O menor elemento da linha onde se encontra o maior elemento da matriz é: " + menor);
            Console.WriteLine("Está na linha: " + posicao[0] + " e coluna: " + posicao[1]);
        }

        //----------------------------------------------------------------------------------
        //MÉTODO PARA O EXERCICIO 2
        private static void CalcularMedia(int[] vetor, int escolha)
        {
            int count = 0;
            double media = 0, soma = 0;
            if (escolha == 1)
            {
                Console.WriteLine("Números selecionados: ");
                for (int i = 0; i < vetor.Length; i++)
                {
                    if (vetor[i] % 2 == 0)
                    {
                        count++;
                        soma += vetor[i];

                        Console.Write(vetor[i] + "  ");
                    }
                }
                media = soma / count;
                Console.WriteLine("A média é " + media);
            }
            else if (escolha == 2)
            {
                Console.WriteLine("Números selecionados: ");
                for (int i = 0; i < vetor.Length; i++)
                {
                    if (vetor[i] % 2 != 0)
                    {
                        count++;
                        soma += vetor[i];

                        Console.Write(vetor[i] + "  ");
                    }
                }
                media = soma / count;
                Console.WriteLine("A média é " + media);
            }
        }
        //----------------------------------------------------------------------------------
        //METODO PARA O EXERCICIO 3
        private static void TransporMatriz(int[,] m)
        {
            int[,] mT = new int[4, 3];

            Console.WriteLine("Matriz normal: ");
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    mT[j, i] = m[i, j];
                    Console.Write("[" + m[i, j] + "]");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matriz T: ");
            for (int i = 0; i < mT.GetLength(0); i++)
            {
                for (int j = 0; j < mT.GetLength(1); j++)
                {
                    Console.Write("[" + mT[i, j] + "]");
                }
                Console.WriteLine();
            }
        }
        //----------------------------------------------------------------------------------
        //METODO PARA O EXERCICIO 4
        static void MultiplicarMatrizes(int[,] m1, int[,] m2)
        {
            int[,] r = new int[2, 2];
            for (int i = 0; i < r.GetLength(0); i++)
            {
                for (int j = 0; j < r.GetLength(1); j++)
                {
                    r[i, j] = m1[i, j] * m2[i, j];
                }
            }
            for (int i = 0; i < r.GetLength(0); i++)
            {
                for (int j = 0; j < r.GetLength(1); j++)
                {
                    Console.Write("[" + r[i, j] + "]");
                }
                Console.WriteLine();
            }
        }
        //--------------------------------------------------------------------------------------
        //EXERCICIO 5
        static void SomaDiagonalPrincipal(int[,] mat)
        {
            int soma = 0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if(i == j)
                    {
                        soma += mat[i, j];
                    }
                }
            }
            Console.WriteLine("A soma da diagonal principal é " + soma);
        }

        //-----------------------------------------------------------------------------------------
        //EXERCICIO 6
        static void MediaColunaMatriz(int [,] mat1, int coluna)
        {
            int soma = 0;
            double media = 0;
            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat1.GetLength(1); j++)
                {
                    if (j == coluna)
                    {
                        soma += mat1[i, coluna];
                    }
                }
            }
            media = soma / mat1.GetLength(1);
            Console.WriteLine("A média dos elementos da coluna "+coluna+" é " + media);
        }
    }
}