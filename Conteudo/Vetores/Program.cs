//TIPO nome;

using System.Runtime.CompilerServices;

//tipo[] nome = new tipo[TAMANHO];
//int tamanho = 5;
//int[] v = new int[tamanho];
//double[] vetor2 = new double[7];

//v[0] = 1;
//v[1] = 8;
//v[2] = 5;
//v[3] = v[1] - v[0];
//v[4] = v[1] * 2;  

//for(int i = 0; i < v.Length; i++)
//{
//    Console.WriteLine("v["+i+"] = " + v[i]);
//}
//-------------------------------------------------
//int tamanho = 5;
//int[] v = new int[tamanho];
//for(int i = 0; i < v.Length; i++)
//{
//    Console.WriteLine("Informe um valor para a posição "+(i+1)+": ");
//    v[i] = int.Parse(Console.ReadLine());
//}
//for (int i = 0; i < v.Length; i++)
//{
//    Console.WriteLine("v[" + i + "] = " + v[i]);
//}
//-------------------------------------------------
/*Exemplo: Realize a soma dos vetores, a quantidade de elementos negativos e mostre o resultado.*/

int soma = 0;
int tamanho = 5;
int cont = 0;
int[] v = new int[tamanho];

for (int i = 0; i < v.Length; i++)
{
    Console.WriteLine("Informe um valor para a posição " + (i + 1) + " do vetor:");
    v[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < v.Length; i++)
{
    soma += v[i];
}

for (int i = 0; i < v.Length; i++)
{
    if (v[i] < 0)
    {
        cont++;
    }
}

for (int i = 0; i < v.Length; i++)
{
    Console.WriteLine("V[" + i + "] = " + v[i]);
}
Console.WriteLine("A soma dos elementos resulta em: " + soma);
Console.WriteLine("A contagem dos elementos negativos em: " + cont);