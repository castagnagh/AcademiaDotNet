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

            double[,] m1 = new double[2,3];
            double[,] m2 = new double[2, 3];
            double[,] soma = new double[2, 3];

            Console.WriteLine("Informe os valores da primeira matriz: ");
            for(int i = 0; i < m1.GetLength(0); i++)
            {
                for(int j = 0; j < m1.GetLength(1); j++)
                {
                    Console.Write("m[" + i + "][" + j + "] = ");
                    m1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Informe os valores da segunda matriz: ");
            for (int i = 0; i < m2.GetLength(0); i++)
            {
                for (int j = 0; j < m2.GetLength(1); j++)
                {
                    Console.Write("m[" + i + "][" + j + "] = ");
                    m2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            for(int i = 0; i < soma.GetLength(0); i++)
            {
                for(int j = 0; j < soma.GetLength(1); j++)
                {
                    soma[i,j] = m1[i,j] + m2[i,j];
                }
            }
            for (int i = 0; i < soma.GetLength(0); i++)
            {
                for (int j = 0; j < soma.GetLength(1); j++)
                {
                    Console.Write("[" + soma[i, j] + "]");
                }
                Console.WriteLine();
            }

        }
    }
}