/*1-Escreva um algoritmo que leia os valores para um vetor de 10 elementos e então mostre na tela a quantidade de números pares e ímpares.*/
//int tamanho = 10, par = 0, impar = 0;
//int[] valor = new int[tamanho];

//for (int i = 0; i < valor.Length; i++)
//{
//    Console.WriteLine("Informe o valor do vetor na posição " +(i+1) + ": ");
//    valor[i] = int.Parse(Console.ReadLine());

//    if (valor[i] %2 == 0)
//    {
//        par++;
//    }
//    else
//    {
//        impar++;
//    }
//}
//Console.WriteLine("A quantidade de numeros pares é: " + par);
//Console.WriteLine("A quantidade de numeros impares é: " + impar);
//-------------------------------------------------------------------------------------------------
/*2. Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então realize a 
 * soma dos elementos da mesma posição, armazenando o resultado em um outro vetor.*/
//int tamanho = 20;
//int[] valor1 = new int[tamanho];
//int[] valor2 = new int[tamanho];
//int[] soma = new int[tamanho];

//for (int i = 0;i < tamanho; i++)
//{
//    Console.WriteLine("Informe o valor1 do vetor na posição " + i + ": ");
//    valor1[i] = int.Parse(Console.ReadLine());
//    Console.WriteLine("Informe o valor2 do vetor na posição " + i + ": ");
//    valor2[i] = int.Parse(Console.ReadLine());
//    soma[i] = valor1[i] + valor1[i];
//}
//for(int i = 0; i < soma.Length; i++)
//{
//    Console.WriteLine("A soma de valor1[" +i+ "] + valor2["+i+"] = " + soma[i]);
//}
//-------------------------------------------------------------------------------------------------
/*3. Escreva um algoritmo que leia os valores para um vetor de 20 elementos e então mostre na tela
 * o índice da posição dos valores correspondentes a números primos.*/
//int tamanho = 20, cont = 0;
//int[] v = new int[tamanho];

//for (int i = 0; i < v.Length; i++)
//{
//    Console.WriteLine("Informe o valor do v[" + i + "]: ");
//    v[i] = int.Parse(Console.ReadLine());
//}
//for(int i = 0;i < v.Length; i++)
//{
//    if (v[i] % i == 0)
//    {
//        cont++;
//    } 
//    if(cont <= 2)
//    {
//        Console.WriteLine("O vetor na posição ["+i+"] é um número primo!");
//    }
//}
//-------------------------------------------------------------------------------------------------
/*4.Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação dos elementos 
 * de mesmo índice, colocando o resultado em um terceiro vetor. Mostre o vetor resultante.
*/
//int tamanho = 10;
//int[] valor1 = new int[tamanho];
//int[] valor2 = new int[tamanho];
//int[] multiplica = new int[tamanho];

//for (int i = 0; i < tamanho; i++)
//{
//    Console.WriteLine("Informe o valor1 do vetor na posição " + i + ": ");
//    valor1[i] = int.Parse(Console.ReadLine());
//    Console.WriteLine("Informe o valor2 do vetor na posição " + i + ": ");
//    valor2[i] = int.Parse(Console.ReadLine());
//    multiplica[i] = valor1[i] * valor1[i];
//}
//for (int i = 0; i < multiplica.Length; i++)
//{
//    Console.WriteLine("A multiplicação de valor1[" + i + "] + valor2[" + i + "] = " + multiplica
//        [i]);
//}
//-------------------------------------------------------------------------------------------------
/*5. Escreva um algoritmo que leia um vetor de 80 elementos inteiros. Encontre e mostre o menor 
 * elemento e a sua posição.*/
//int tamanho = 8;
//int[] v = new int[tamanho];

//for (int i = 0; i < v.Length; i++)
//{
//    Console.WriteLine("Informe o numero: ");
//    v[i] = int.Parse(Console.ReadLine());
//}
//int menor = v[0];
//for(int i = 1; i < v.Length; i++)
//{
//    if (v[i] < menor)
//    {
//        menor = v[i];
//    }
//}
//Console.WriteLine("O menor valor é: " + menor);
//-------------------------------------------------------------------------------------------------
/*6. Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à ordem de leitura. Exemplo:
a.	lê: 		|7|40|3|9|21|0|63|31|7|22|
b.	escreve: 	|22|7|31|63|0|21|9|3|40|7|*/

//int tamanho = 10;
//int[] num = new int[tamanho];

//for (int i = 0; i < num.Length; i++)
//{
//    Console.WriteLine("Informe o "+i+" º número: ");
//    num[i] = int.Parse(Console.ReadLine());
//}
//for (int i = 0; i < num.Length; i++)
//{
//    Console.Write(num[i] + "|");
//}
//Console.WriteLine(" ");
//for (int i = num.Length - 1; i >= 0; i--)
//{
//    Console.Write(num[i] + "|");
//}
//-------------------------------------------------------------------------------------------------
/*7.	Fazer um algoritmo que leia dez números inteiros armazenando-os em um vetor e escreva primeiramente todos os números pares lidos e após todos os ímpares. Exemplo:
a.	lê: 		|7|40|3|9|21|0|63|31|7|22|
b.	escreve: 	|40|0|22|7|3|9|21|63|31|7|*/

//int tam = 10;
//int[] num =  new int[tam];
//for (int i = 0; i < num.Length; i++){
//    Console.Write("Informe um número inteiro: ");
//    num[i] = int.Parse(Console.ReadLine());

//}
//for(int i = 0; i < num.Length; i++)
//{
//        Console.Write(num[i] + "|");
//}
//Console.WriteLine(" ");
//for (int i = 0; i < num.Length; i++)
//{
//    if (num[i] % 2 == 0)
//    {
//        Console.Write(num[i] + "|");
//    }
//}
//for (int i = 0; i < num.Length; i++)
//{
//    if (num[i] % 2 != 0)
//    {
//        Console.Write(num[i] + "|");
//    }
//}
//-------------------------------------------------------------------------------------------------
/*8.	Fazer um algoritmo que leia trinta números reais armazenando-os em um vetor e após escreva a 
 * posição de cada número menor que zero desse vetor. 
 * Exemplo:
a.	lê:          	|5.1|0|-3.6|4.1|-2.5|-1.3|-4|1.39|-128|-6.9|8.2|9|154|-88|6.4|7.1|...|
b.	escreve: 	|3|5|6|7|9|10|14|. . .
 */
//FIZ COM INT, me dei conta depois
//int tam = 10;
//int[] num = new int[tam];
//for (int i = 0; i < num.Length; i++)
//{
//    Console.Write("Informe um número inteiro: ");
//    num[i] = int.Parse(Console.ReadLine());

//}
//for (int i = 0; i < num.Length; i++)
//{
//    Console.Write(num[i] + "|");
//}
//Console.WriteLine(" ");
//for (int i = 0; i < num.Length; i++)
//{
//    if (num[i] < 0)
//    {
//        Console.Write(i + "|");
//    }
//}
//-------------------------------------------------------------------------------------------------
/*9. Escreva um algoritmo que leia os valores para um vetor de 10 elementos, e em seguida ordene em 
 * ordem crescente os valores desse vetor, utilizando um vetor auxiliar.
*/
//int[] v = new int[10] {9, 7, 1, 3, 2, 5, 8, 6, 0, 4};
//int aux;
//for (int i = 0; i < v.Length; i++)
//{
//    for (int j = 0; j < (v.Length - 1); i++)
//    {
//        aux = v[j];
//        v[j] = v[j + 1];
//        v[j+1] = aux;
//    }
//}
//for(int i = 0; i < v.Length; i++)
//{
//    Console.WriteLine("Vetor[" + i + "] = " + v[i]);
//}
//-------------------------------------------------------------------------------------------------
/*10.	Escreva um algoritmo que leia um vetor inteiro de 20 posições. Crie um segundo vetor, 
 * substituindo os valores nulos por 2. Mostre os vetores lidos e o vetor resultado.*/
//int tamanho = 10;
//int[] n = new int[tamanho];
//int[] n2 = new int[tamanho];

//for (int i = 0; i < n.Length; i++)
//{
//    Console.WriteLine("Informe o valor: ");
//    n[i] = int.Parse(Console.ReadLine());

//}
//for (int i = 0; i < n.Length; i++)
//{
//    Console.Write(n[i] +"|");
//}
//Console.WriteLine(" ");
//for (int i = 0; i < n.Length; i++)
//{
//    n2[i] = n[i];
//    if (n[i] == 0)
//    {
//        n2[i] = 2;
//    }
//}
//for (int i = 0; i < n2.Length; i++)
//{
//    Console.Write(n2[i] +"|");
//}
//-------------------------------------------------------------------------------------------------
/*11. Escreva um programa que leia valores em um vetor de 5 posições. Escrever os elementos do vetor 
 * e após escrever os elementos na ordem inversa.*/
//SOLUÇÃO IGUAL A DA QUESTÃO 6
//------------------------------------------------------------------------------------------------
/*12. Faça um algoritmo que leia um vetor V de 10 posições e, após, verifica se um número N, fornecido 
 * pelo usuário, existe no vetor. Se existir, indicar a(s) posição(ões), senão escrever a mensagem 
 * "O número fornecido não existe no vetor!".*/

//int tam = 10, n = 0;
//int[] v = new int[tam];
//for (int i = 0;i < v.Length; i++)
//{
//    Console.WriteLine("Informe um valor do vetor: ");
//    v[i] = int.Parse(Console.ReadLine());
//}
//Console.WriteLine("Informe um valor N para verificar se existe no vetor: ");
//n = int.Parse(Console.ReadLine());
//for (int i = 0; i < v.Length; i++)
//{

//    if (n == v[i])
//    {
//        Console.WriteLine("O numero informado esta na posição: " + i);
//        break;
//    }
//    else
//    {
//        Console.WriteLine("O número fornecido não existe no vetor!");
//        break;
//    }
//}
//-------------------------------------------------------------------------------------------------
/*13. Escreva um algoritmo para ler um vetor de inteiros e positivos e imprimir quantas vezes aparecem 
 * os números 2, 4 e 8. O vetor terá no máximo 100 posições. Sair do programa quando for digitado -1 ou 
 * quando atingir o máximo de posições do vetor.*/
//int tam = 100, contDois = 0, contQuatro = 0, contOito = 0, cont = 0;
//int[] n = new int[tam];

//while (cont < tam)
//{
//    Console.WriteLine("Informe um valor: ");
//    n[cont] = int.Parse(Console.ReadLine());

//    if (n[cont] == -1)
//    {
//        break;
//    }

//    if (n[cont] == 2)
//    {
//        contDois++;
//    }
//    else if (n[cont] == 4)
//    {
//        contQuatro++;
//    }
//    else if (n[cont] == 8)
//    {
//        contOito++;
//    }

//    cont++;
//}

//Console.WriteLine("O numero 2 apareceu " + contDois + " vezes");
//Console.WriteLine("O numero 4 apareceu " + contQuatro + " vezes");
//Console.WriteLine("O numero 8 apareceu " + contOito + " vezes");
//-------------------------------------------------------------------------------------------------
/*14.	Escreva um algoritmo que leia um código numérico inteiro e um vetor de 50 posições de números. 
 * Se o código for zero, termine o algoritmo. Se o código for 1, mostre o vetor na ordem em que foi lido. 
 * Se o código for 2, mostre o vetor na ordem inversa, do último elemento até o primeiro.*/

//int tam = 5;
//int[] num = new int[tam];
//int op;

//for (int i = 0; i < num.Length; i++)
//{
//    Console.WriteLine("Informe um numero inteiro: ");
//    num[i] = int.Parse(Console.ReadLine());
//}
//Console.WriteLine("MENU DE OPÇÕES");
//Console.WriteLine("0 - Terminar o programa");
//Console.WriteLine("1 - Mostrar vetor (ordem normal)");
//Console.WriteLine("2 - Mostrar vetor (ordem inversa)");
//op = int.Parse(Console.ReadLine());

//switch (op)
//{
//    case 0: return;
//        break;
//    case 1: 
//        for(int i = 0; i < num.Length; i++)
//        {
//            Console.WriteLine("v["+i+"] = " + num[i]);
//        };
//        break;
//    case 2:
//        for (int i = num.Length-1; i >= 0; i--)
//        {
//            Console.WriteLine("v[" + i + "] = " + num[i]);
//        }; ;
//        break;
//    default:
//        Console.WriteLine("Opção inválida!");
//        break;
//}
//-------------------------------------------------------------------------------------------------
/*15.	Faça um programa em C que declare um vetor de 20 elementos inteiros, leia os conteúdos do vetor, 
 * e copie estes conteúdos para outro vetor, invertendo sua ordem. Assim, o valor do primeiro elemento 
 * do primeiro vetor deve ser o valor do último elemento do segundo vetor, por exemplo. Mostrar os 
 * conteúdos do primeiro vetor em uma linha e os do segundo uma linha abaixo.
*/

//int tam = 10;
//int[] v1 = new int[tam];
//int[] v2 = new int[tam];
//int posicao = (v1.Length-1);
//for (int i = 0; i < v1.Length; i++)
//{
//    Console.WriteLine("Informe o valor do vetor: ");
//    v1[i] = int.Parse(Console.ReadLine());
//}
//for (int i = 0; i < tam; i++)
//{
//    v2[posicao] = v1[i];
//    posicao--;
//}
//for (int i = 0; i < v1.Length; i++)
//{
//    Console.Write(v1[i] + "|");
//}
//Console.WriteLine(" ");
//for (int i = 0; i < v2.Length; i++)
//{
//    Console.Write(v2[i] + "|");
//}
//-------------------------------------------------------------------------------------------------
/*16.	Escreva um algoritmo que leia 2 vetores X[10] e Y[10] e os escreva. Crie, a seguir, um vetor para cada uma das operações:
•	A união de X com Y
•	A diferença entre X e Y
•	A interseção entre X e Y
Escreva o vetor resultado de cada uma das operações.*/

//int[] x = new int[4] { 0, 1, 2, 3 };
//int[] y = new int[4] { 3, 4, 5, 6 };

//int[] uniao = new int[8];
//int[] diferenca = new int[4];
//int[] interseccao = new int[4];

////UNIÃO 
//x.CopyTo(uniao, 0);

//int aux = 4;

//for (int i = 0; i < y.Length; i++)
//{
//    for (int j = 0; j < x.Length; j++)
//    {
//        if (y[i] == x[j])
//        {
//            break;
//        }

//        if (j == (x.Length - 1))
//        {
//            uniao[aux] = y[i];
//            aux++;
//        }
//    }
//}

//for (int i = 0; i < aux; i++)
//{
//    Console.WriteLine("união[" + i + "] = " + uniao[i]);
//}
//int aux2 = 0;
////DIFERENÇA
//for (int i = 0; i < y.Length; i++)
//{
//    for (int j = 0; j < x.Length; j++)
//    {
//        if (y[i] == x[j])
//        {
//            break;
//        }

//        if (j == (x.Length - 1))
//        {
//            diferenca[aux2] = x[i];
//            aux2++;
//        }
//    }
//}
//for (int i = 0; i < aux2; i++)
//{
//    Console.WriteLine("diferença[" + i + "] = " + diferenca[i]);
//}

