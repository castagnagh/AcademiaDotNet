using System.Runtime.Serialization;

namespace ExerciciosMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1) Crie uma Matriz 5x3. Na primeira coluna, solicite que o usuário preencha. 
             * A 2ª coluna, some 10 aos elementos da 1ª coluna. 
             * Na 3º coluna, armazene o dobro dos elementos da 1ª coluna.*/
            //int[,] m = new int[5,3];
            //Console.WriteLine("Informe: ");
            //for (int i = 0; i < m.GetLength(0); i++)
            //{
            //    Console.Write("M[" + i + ",0] = ");
            //    m[i,0] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < m.GetLength(0); i++)
            //{
            //    m[i, 1] = m[i,0] + 10;
            //    m[i, 2] = m[i,0] * 2;
            //}
            //for(int i = 0; i < m.GetLength(0); i++)
            //{
            //    for(int j = 0; j <m.GetLength(1); j++)
            //    {
            //        Console.Write("[" + m[i,j] + "]");
            //    }
            //    Console.WriteLine();
            //}
            //-------------------------------------------------------------------------------------
            /*2) Solicite ao usuário, preencher uma Matriz 3x3

            Informe ao usuário:
            *A soma dos elementos de cada linha
	            -Ex: Linha 1: 30
	                 Linha 2: 17
            *A soma dos elementos de cada coluna
	            -Ex: Coluna 1: 23
	                 Coluna 2: 36*/
            //int[,] m = new int[3,3];
            //int somaL = 0, somaC = 0;

            //for(int i = 0; i < m.GetLength(0); i++)
            //{
            //    for(int j = 0; j < m.GetLength(1); j++)
            //    {
            //        Console.Write("m[" + i + "][" + j + "] = ");
            //        m[i,j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < m.GetLength(0); i++)
            //{
            //    for (int j = 0; j < m.GetLength(1); j++)
            //    {
            //        Console.Write("[" + m[i, j] + "]");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //for (int i = 0;i < m.GetLength(0); i++)
            //{
            //    for(int j = 0;j < m.GetLength(1); j++)
            //    {
            //        somaL += m[i, j];
            //    }
            //    Console.WriteLine("Soma Linha " + i + ": " + somaL);
            //    somaL = 0;
            //}
            //Console.WriteLine();
            //for (int j = 0; j < m.GetLength(0); j++)
            //{
            //    for (int i = 0; i < m.GetLength(1); i++)
            //    {
            //        somaC += m[i, j];
            //    }
            //    Console.WriteLine("Soma Coluna " + j + ": " + somaC);
            //    somaC = 0;
            //}
            //-------------------------------------------------------------------------------------
            /*3) Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!*/
            //int[,] m = new int[4,4];

            //for(int i = 0; i < m.GetLength(0); i++)
            //{
            //    for(int j = 0; j < m.GetLength(1); j++)
            //    {
            //        Console.Write("m[" + i + "][" + j + "] = ");
            //        m[i,j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine();
            //for (int i = 0; i < m.GetLength(0); i++)
            //{
            //    for (int j = 0; j < m.GetLength(1); j++)
            //    {
            //        Console.Write("[" + m[i, j] + "]");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //for (int i = 0; i < m.GetLength(0); i++)
            //{
            //    for(int j = 0; j < m.GetLength(1); j++)
            //    {
            //        if(i == j)
            //        {
            //            Console.WriteLine(m[i,j]);
            //        }
            //    }
            //}
            //-------------------------------------------------------------------------------------
            /*4) Popule uma matriz 5x5 e informe:
            -Quantos números são pares
            -Quantos números são impares
            -Quantos números são positivos
            -Quantos números são negativos
            -Quantos zeros existem!*/

            //int[,] m = new int[5, 5];
            //int contPar = 0, contImpar = 0, contPositivo = 0, contNegativo = 0, contZero = 0;

            //for (int i = 0; i < m.GetLength(0); i++)
            //{
            //    for (int j = 0; j < m.GetLength(1); j++)
            //    {
            //        Console.Write("m[" + i + "][" + j + "] = ");
            //        m[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine();
            //for (int i = 0; i < m.GetLength(0); i++)
            //{
            //    for (int j = 0; j < m.GetLength(1); j++)
            //    {
            //        Console.Write("[" + m[i, j] + "]");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //for (int i = 0; i < m.GetLength(0); i++)
            //{
            //    for (int j = 0; j < m.GetLength(1); j++)
            //    {
            //        if(m[i, j] % 2 == 0)
            //        {
            //            contPar++;
            //        } else
            //        {
            //            contImpar++;
            //        }
            //        if (m[i, j] > 0)
            //        {
            //            contPositivo++;
            //        } else if (m[i, j] < 0)
            //        {
            //            contNegativo++;
            //        } else
            //        {
            //            contZero++;
            //        }
            //    }                
            //}
            //Console.WriteLine("Quantidade de números pares: " + contPar);
            //Console.WriteLine("Quantidade de números impares: " + contImpar);
            //Console.WriteLine("Quantidade de números positivos: " + contPositivo);
            //Console.WriteLine("Quantidade de números negativos: " + contNegativo);
            //Console.WriteLine("Quantidade de números iguais a zero: " + contZero);
            //-------------------------------------------------------------------------------------
            /*5) Leia duas matrizes 2x3 de números double. 
            Imprima a soma destas duas matrizes.*/

            //double[,] m1 = new double[2,3];
            //double[,] m2 = new double[2, 3];
            //double[,] soma = new double[2, 3];

            //Console.WriteLine("Informe os valores da primeira matriz: ");
            //for(int i = 0; i < m1.GetLength(0); i++)
            //{
            //    for(int j = 0; j < m1.GetLength(1); j++)
            //    {
            //        Console.Write("m[" + i + "][" + j + "] = ");
            //        m1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("Informe os valores da segunda matriz: ");
            //for (int i = 0; i < m2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < m2.GetLength(1); j++)
            //    {
            //        Console.Write("m[" + i + "][" + j + "] = ");
            //        m2[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine();
            //for(int i = 0; i < soma.GetLength(0); i++)
            //{
            //    for(int j = 0; j < soma.GetLength(1); j++)
            //    {
            //        soma[i,j] = m1[i,j] + m2[i,j];
            //    }
            //}
            //for (int i = 0; i < soma.GetLength(0); i++)
            //{
            //    for (int j = 0; j < soma.GetLength(1); j++)
            //    {
            //        Console.Write("[" + soma[i, j] + "]");
            //    }
            //    Console.WriteLine();
            //}
            //-------------------------------------------------------------------------------------
            /*6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-9. Após isso determine o maior número da matriz.
            Random random = new Random();
            int randomNumber = random.Next(0, 100);*/

            //int[,] m = new int[4,4];
            //int maior = 0;
            //Random random = new Random();
            //for (int i = 0; i < m.GetLength(0); i++)
            //{
            //    for (int j = 0; j < m.GetLength(1); j++)
            //    {
            //        int randomNumber = random.Next(0, 9);
            //        m[i, j] = randomNumber;
            //        if (m[i,j] > maior)
            //        {
            //            maior = m[i,j];
            //        }
            //    }
            //}
            //for(int i = 0; i < m.GetLength(0); i++)
            //{
            //    for(int j = 0;j < m.GetLength(1); j++)
            //    {
            //        Console.Write("[" + m[i, j] + "]");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("O maior número da matriz é: " + maior);
            //-------------------------------------------------------------------------------------
            /*7) Leia duas matrizes A e B com 3x3 elementos. Construir uma matriz C, onde cada elemento 
             * de C é a subtração do elemento correspondente de A com B.*/

            //int[,] a = new int[3, 3];
            //int[,] b = new int[3, 3];
            //int[,] c = new int[3, 3];

            //Console.WriteLine("Informe os valores da primeira matriz: ");
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        Console.Write("a[" + i + "][" + j + "] = ");
            //        a[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("Informe os valores da segunda matriz: ");
            //for (int i = 0; i < b.GetLength(0); i++)
            //{
            //    for (int j = 0; j < b.GetLength(1); j++)
            //    {
            //        Console.Write("b[" + i + "][" + j + "] = ");
            //        b[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine();
            //for (int i = 0; i < c.GetLength(0); i++)
            //{
            //    for (int j = 0; j < c.GetLength(1); j++)
            //    {
            //        c[i, j] = a[i, j] - b[i, j];
            //    }
            //}
            //Console.WriteLine("A subtração da matriz A-B: ");
            //for (int i = 0; i < c.GetLength(0); i++)
            //{
            //    for (int j = 0; j < c.GetLength(1); j++)
            //    {
            //        Console.Write("[" + c[i, j] + "]");
            //    }
            //    Console.WriteLine();
            //}
            //-------------------------------------------------------------------------------------
            /*8) Ler uma matriz com 4x4 de inteiros e mostrar os números na ordem direta e inversa a 
             * que foram lidos.*/

            //int[,] m = new int[4,4];

            //for(int i = 0; i < m.GetLength(0); i++)
            //{
            //    for(int j = 0; j < m.GetLength(1); j++)
            //    {
            //        Console.Write("m[" + i + "][" + j + "] = ");
            //        m[i,j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("Ordem direta: ");
            //for (int i = 0; i < m.GetLength(0); i++ )
            //{
            //    for(int j = 0; j < m.GetLength(1); j++)
            //    {
            //        Console.Write("["+ m[i,j] +"]");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Ordem inversa: ");
            //for (int i = (m.GetLength(0)-1); i >=0 ; i--)
            //{
            //    for (int j = (m.GetLength(1)-1); j >=0; j--)
            //    {
            //        Console.Write("[" + m[i,j] + "]");
            //    }
            //    Console.WriteLine();
            //}
            //-------------------------------------------------------------------------------------
            /*9) Leia uma matriz 3x3.  Em seguida, solicite um número qualquer ao usuário e pesquise 
             * na matriz se o número existe.  
            Caso, seja verdade imprima a mensagem:  “O número existe no vetor” , caso contrário “Número inexistente”.*/

            //int[,] m = new int[3,3];
            //bool encontrado = false;

            //for(int i = 0; i < m.GetLength(0); i++)
            //{
            //    for(int j = 0; j < m.GetLength(1); j++)
            //    {
            //        Console.Write("m["+i+","+j+"] = ");
            //        m[i,j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < m.GetLength(0); i++)
            //{
            //    for (int j = 0; j < m.GetLength(1); j++)
            //    {
            //        Console.Write("[" + m[i,j] + "]");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Digite um número qualquer: ");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 0; i < m.GetLength(0); i++)
            //{
            //    for (int j = 0; j < m.GetLength(1); j++)
            //    {
            //        if(num == m[i,j])
            //        {
            //            encontrado = true;  
            //        } 
            //    }
            //}
            //if (encontrado)
            //{
            //    Console.WriteLine("O número existe no vetor");
            //} else
            //{
            //    Console.WriteLine("O número não existe no vetor");
            //}
            //-------------------------------------------------------------------------------------
            /*10) Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos, em seguida, 
             * diga quantos dos elementos lidos estão abaixo, acima e na média.*/

            //int[,] a = new int[2,2];
            //int[,] b = new int[2,2];

            //int soma = 0, acima = 0, abaixo = 0, naMedia = 0;
            //Console.WriteLine("Informe os elementos da matriz A: ");
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        Console.Write("m[" + i + "," + j + "] = ");
            //        a[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("Informe os elementos da matriz B: ");
            //for (int i = 0; i < b.GetLength(0); i++)
            //{
            //    for (int j = 0; j < b.GetLength(1); j++)
            //    {
            //        Console.Write("m[" + i + "," + j + "] = ");
            //        b[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        soma += a[i, j];
            //    }
            //}
            //for (int i = 0; i < b.GetLength(0); i++)
            //{
            //    for (int j = 0; j < b.GetLength(1); j++)
            //    {
            //        soma += b[i, j];
            //    }
            //}
            //double media = soma / (a.Length*2);
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        //matrizA
            //        if (a[i, j] > (media))
            //        {
            //            acima++;
            //        }
            //        else if (a[i, j] < (media))
            //        {
            //            abaixo++;
            //        }
            //        else
            //        {
            //            naMedia++;
            //        }
            //    }
            //}
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        //matrizB
            //        if (b[i, j] > (media))
            //        {
            //            acima++;
            //        }
            //        else if (b[i, j] < (media))
            //        {
            //            abaixo++;
            //        }
            //        else
            //        {
            //            naMedia++;
            //        }
            //    }
            //}
            //Console.WriteLine("Valor da média: " + (double)media);
            //Console.WriteLine("Quantidade de valores acima da média: " + acima);
            //Console.WriteLine("Quantidade de valores abaixo da média: " + abaixo);
            //Console.WriteLine("Quantidade de valores que estão na média: " + naMedia);
            //-------------------------------------------------------------------------------------
            /*11) Leia uma matriz A de tipo double de dimenção 3x3, crie uma nova matriz resultante 
             * da divisão dos elementos da matriz A pela soma dos seus indices.*/

            //double[,] a = new double[3, 3];
            //double[,] resultante = new double[3, 3];
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        Console.Write("a[" + i + "," + j + "] = ");
            //        a[i, j] = double.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        //aqui atribui ZERO para caso o i+j seja igual a ZERO, pois não existe divisão por zero
            //        if((i+j) != 0)
            //        {
            //            resultante[i, j] = a[i, j] / (i + j);
            //        }
            //        else
            //        {
            //            resultante[i,j] = 0;
            //        }
            //    }
            //}
            //for (int i = 0; i < resultante.GetLength(0); i++)
            //{
            //    for (int j = 0; j < resultante.GetLength(1); j++)
            //    {
            //        Console.Write("["+ resultante[i, j] + "]");
            //    }
            //    Console.WriteLine();
            //}
            //-------------------------------------------------------------------------------------
            /*12) Escreva um programa que leia os valores de uma matriz 4x3, e em seguida mostre na 
             * tela apenas os valores cuja soma dos índices (i+j) seja um número par.*/
            //int[,] m = new int[4, 3];

            //for(int i = 0; i < m.GetLength(0); i++)
            //{
            //    for(int j = 0; j < m.GetLength(1); j++)
            //    {
            //        Console.Write("m["+i+","+j+"] = ");
            //        m[i,j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("matriz completa: ");
            //for (int i = 0; i < m.GetLength(0); i++)
            //{
            //    for (int j = 0; j < m.GetLength(1); j++)
            //    {
            //        Console.Write("[" + m[i, j] + "]");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("somente os numeros pares: ");
            //for (int i = 0; i < m.GetLength(0); i++)
            //{
            //    for (int j = 0; j < m.GetLength(1); j++)
            //    {
            //        if((i+j)%2 == 0)
            //        {
            //            Console.Write("[" + m[i,j] +"]");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //-------------------------------------------------------------------------------------
            /*13) Escreva um programa que leia uma matriz de ordem 5 (ou seja, 5x5) e verifique se a 
             * soma dos elementos da diagonal principal é igual a soma dos elementos da diagonal secundária.*/

            //int[,] m = new int[5, 5];
            //int somaP = 0, somaS = 0;

            //for(int i = 0; i < m.GetLength(0); i++) 
            //{ 
            //    for(int j = 0; j < m.GetLength(1); j++)
            //    {
            //        Console.Write("m["+i+","+j+"] = ");
            //        m[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < m.GetLength(0); i++)
            //{
            //    for (int j = 0; j < m.GetLength(1); j++)
            //    {
            //       if(i == j)
            //       {
            //            somaP += m[i, j];
            //       }
            //       if((i + j) == (m.GetLength(0) - 1))
            //        {
            //            somaS += m[i,j];
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 0; i < m.GetLength(0); i++)
            //{
            //    for (int j = 0; j < m.GetLength(1); j++)
            //    {
            //        Console.Write("[" + m[i, j] + "]");
            //    }
            //    Console.WriteLine();
            //}
            //if(somaP == somaS)
            //{
            //    Console.WriteLine("A soma da diagona principal é IGUAL a diagonal secundária");
            //}
            //else
            //{
            //    Console.WriteLine("A soma da diagonal principal NÃO É IGUAL a diagonal secundária");
            //}
            //Console.WriteLine("Soma Diagnonal Principal: " + somaP);
            //Console.WriteLine("Soma Diagonal Secundária: " + somaS);
            //-------------------------------------------------------------------------------------
            /*14) Escreva um programa que leia uma matriz de ordem 5 e verifique se os elementos da 
            diagonal principal (da esquerda para a direita) são os mesmos da diagonal secundária (direita pra esquerda).*/

            //int[,] m = new int[3, 3];
            //int[] s = new int[3];
            //int[] p = new int[3];

            //for (int i = 0; i < m.GetLength(0); i++)
            //{
            //    for (int j = 0; j < m.GetLength(1); j++)
            //    {
            //        Console.Write("m[" + i + "," + j + "] = ");
            //        m[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < m.GetLength(0); i++)
            //{
            //    for (int j = 0; j < m.GetLength(1); j++)
            //    {
            //        if (i == j)
            //        {
            //            p[i] = m[i,j];
            //        }
            //        if ((i + j) == (m.GetLength(0) - 1))
            //        {
            //            s[i] = m[i, j];
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 0; i < m.GetLength(0); i++)
            //{
            //    for (int j = 0; j < m.GetLength(1); j++)
            //    {
            //        Console.Write("[" + m[i, j] + "]");
            //    }
            //    Console.WriteLine();
            //}
            //for(int i = 0; i < m.GetLength(0); i++)
            //{
            //    if (p[i] == s[i])
            //    {
            //        Console.WriteLine("O elemento da diagonal principal " + p[i] + " é igual ao elemento da diagonal secundária " + s[i] );
            //    }
            //    else
            //    {
            //        Console.WriteLine("O elemento da diagonal principal " + p[i] + " NÃO é igual ao elemento da diagonal secundária " + s[i]);
            //    }
            //}
            //-------------------------------------------------------------------------------------
            /*15) Escreva um programa em C# para ler os valores e somar duas matrizes 4 x 4. Mostrar a matriz resultante.*/
            //int[,] m1 = new int[4, 4];
            //int[,] m2 = new int[4, 4];
            //int[,] soma = new int[4, 4];

            //Console.WriteLine("Informe os valores da primeira matriz: ");
            //for (int i = 0; i < m1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < m1.GetLength(1); j++)
            //    {
            //        Console.Write("m[" + i + "][" + j + "] = ");
            //        m1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("Informe os valores da segunda matriz: ");
            //for (int i = 0; i < m2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < m2.GetLength(1); j++)
            //    {
            //        Console.Write("m[" + i + "][" + j + "] = ");
            //        m2[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine();
            //for (int i = 0; i < soma.GetLength(0); i++)
            //{
            //    for (int j = 0; j < soma.GetLength(1); j++)
            //    {
            //        soma[i, j] = m1[i, j] + m2[i, j];
            //    }
            //}
            //for (int i = 0; i < soma.GetLength(0); i++)
            //{
            //    for (int j = 0; j < soma.GetLength(1); j++)
            //    {
            //        Console.Write("[" + soma[i, j] + "]");
            //    }
            //    Console.WriteLine();
            //}
            //-------------------------------------------------------------------------------------
            /*16) Escreva um algoritmo para transpor uma matriz 3x4 para outra 4x3. Transpor uma matriz 
             * significa transformar suas linhas em colunas e vice-versa.*/

            //int[,] m = new int[3, 4];
            //int[,] mT = new int[4, 3];

            //for(int i = 0; i < m.GetLength(0); i++)
            //{
            //    for(int j = 0; j < m.GetLength(1); j++)
            //    {
            //        Console.Write("["+i+","+j+"] = ");
            //        m[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("Matriz normal: ");
            //for (int i = 0; i < m.GetLength(0); i++)
            //{
            //    for (int j = 0;j < m.GetLength(1); j++)
            //    {
            //        mT[j,i] = m[i, j];
            //         Console.Write("[" + m[i,j] +"]");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Matriz T: ");
            //for (int i = 0; i < mT.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mT.GetLength(1); j++)
            //    {
            //        Console.Write("[" + mT[i, j] + "]");
            //    }
            //    Console.WriteLine();
            //}
            //-------------------------------------------------------------------------------------
            /*17) Fazer um algoritmo que leia uma matriz de 10 linhas por 10 colunas e escreva o elemento minimax, ou seja,o menor elemento da linha onde se encontra o 
            maior elemento da matriz. Escreva também a linha e a coluna onde foi encontrado.*/
            //int[,] m = new int[10, 10];
            //int maior = 0;
            //int menor = 0;
            //int[] posicao = new int[2];

            ////le os dados da matriz
            //for (int i = 0; i < m.GetLength(0); i++)
            //{
            //    for (int j = 0; j < m.GetLength(0); j++)
            //    {
            //        Console.Write("[" + i + "," + j + "] = ");
            //        m[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            ////laço para verificar qual o maior elemento da matriz
            //for (int i = 0; i < m.GetLength(0); i++)
            //{
            //    for (int j = 0; j < m.GetLength(0); j++)
            //    {
            //        if (m[i, j] > maior)
            //        {
            //            maior = m[i, j];
            //            //quando encontra o maior número armazena o indice no vetor POSICAO[0]
            //            posicao[0] = i;
            //            posicao[1] = j;
            //        }
            //    }
            //}
            ////mostra a matriz
            //for (int i = 0; i < m.GetLength(0); i++)
            //{
            //    for (int j = 0; j < m.GetLength(0); j++)
            //    {
            //        Console.Write("[" + m[i, j] + "]");
            //    }
            //    Console.WriteLine();
            //}
            ////aqui ele procura somente na linha "posicao[0]" indice foi armazenado no vetor
            ////atribuo o menor valor ao elemento da primeira posicao da linha
            //menor = m[posicao[0], 0];
            //for (int j = 0; j < m.GetLength(1); j++)
            //{
            //    if (m[posicao[0], j] <= menor)
            //    {
            //        menor = m[posicao[0], j];
            //        posicao[0] = posicao[0];
            //        posicao[1] = j;
            //    }
            //}

            //Console.WriteLine("Maior elemento encontrado na matriz: " + maior);
            //Console.WriteLine("O menor elemento da linha onde se encontra o maior elemento da matriz é: " + menor);
            //Console.WriteLine("Está na linha: " + posicao[0] + " e coluna: " + posicao[1]);
        }
    }
}