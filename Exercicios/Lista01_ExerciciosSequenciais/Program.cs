/*1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.

int valor1, valor2;
float media;

Console.Write("Digite um valor inteiro: ");
valor1 = int.Parse(Console.ReadLine());

Console.Write("Digite um valor inteiro: ");
valor2 = int.Parse(Console.ReadLine());

media = (valor1 + valor2) / 2;

Console.WriteLine("A média dos valores é: " + media);
*/

//----------------------------------------------------------------------------------------------------------

/*2) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.

int valor1, valor2, valor3, valor4;
float media;

Console.Write("Digite um valor inteiro: ");
valor1 = int.Parse(Console.ReadLine());

Console.Write("Digite um valor inteiro: ");
valor2 = int.Parse(Console.ReadLine());

Console.Write("Digite um valor inteiro: ");
valor3 = int.Parse(Console.ReadLine());

Console.Write("Digite um valor inteiro: ");
valor4 = int.Parse(Console.ReadLine());

media = (valor1 + valor2 + valor3 + valor4) / 4;

Console.WriteLine("A média dos valores é: " + media);
*/

//-----------------------------------------------------------------------------------------------------------

/*3) Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre 
 * si os valores de duas variáveis A e B.

int a = 1;
int b = 2;

int temp = a;
a = b;
b = temp;
*/
//-----------------------------------------------------------------------------------------------------------
/*
4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na 
forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.

Console.WriteLine("Digite uma data (DD/MM/AAAA): ");
DateOnly data = DateOnly.Parse(Console.ReadLine());

Console.WriteLine("Transformando a data para: ");
Console.WriteLine("AAAAMMDD: " + data.Year + "/" + data.Month.ToString("D2") + "/" + data.Day.ToString("D2"));
Console.WriteLine("AAMMDD: " + data.Year.ToString().Substring(2) + "/" + data.Month.ToString("D2") + "/" + data.Day.ToString("D2"));
*/
//-----------------------------------------------------------------------------------------------------------
/*
5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
(medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de combustível 
consumido para percorrê-la (medido em l).
float distancia, litros, consumoMedio;

Console.WriteLine("Informe a distância percorrida: ");
distancia = float.Parse(Console.ReadLine());
Console.WriteLine("Informe a quantidade de litros utilizada: ");
litros = float.Parse(Console.ReadLine());

consumoMedio = distancia / litros;

Console.WriteLine("O consumo médio do seu automovél é: " + consumoMedio + " (Km/L)");
*/
//----------------------------------------------------------------------------------------------------------

/*6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, 
isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem 
de IPI (única) a ser acrescentada. 

*/
//----------------------------------------------------------------------------------------------------------
/*
7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, 
o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. 
Calcule o salário total do vendedor. Escreva o número do vendedor e o salário total do vendedor.
int numVendedor;
double salarioFixo, salarioTotal, totalVendas, percentual;

Console.WriteLine("Digite o número do vendedor: ");
numVendedor = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o salário fixo do vendedor: ");
salarioFixo = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o total de vendas deste vendedor: ");
totalVendas = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o percentual sobre o total de vendas: ");
percentual = int.Parse(Console.ReadLine());

salarioTotal = salarioFixo + ((percentual / 100) * totalVendas);

Console.WriteLine("O salário total do vendedor é: " + salarioTotal);
*/
//-----------------------------------------------------------------------------------------------------------
/*
8) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
A fórmula da conversão é F=(9*C+160)/ 5.

int celsius, fahrenheit;

Console.WriteLine("Informe a temperatura em ºC: ");
celsius = int.Parse(Console.ReadLine());

fahrenheit = (9 * celsius + 160) / 5;

Console.WriteLine("A temperatura em Fahreheint é: " + fahrenheit + " ºF");
*/
//-----------------------------------------------------------------------------------------------------------
/*
9) Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior 
do que ou igual às prestações, que devem ser iguais, inteiras e as maiores possíveis. 
Por exemplo, se o valor da mercadoria for R$ 270,00, a entrada e as duas prestações são iguais a R$ 90,00;
se o valor da mercadoria for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00.
Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
da entrada e das duas prestações, de acordo com as regras acima. 
Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o 
conseqüente pagamento dos boletos das duas prestações.

double valor, entrada, parcela, restoDiv;

Console.WriteLine("Informe o valor da compra: ");
valor = double.Parse(Console.ReadLine());

if ((valor % 3) == 0)
{

    entrada = valor / 3;
    parcela = entrada;
    Console.WriteLine("Entrada: " + entrada);
    Console.WriteLine("1x: " + parcela);
    Console.WriteLine("2x: " + parcela);
}
else
{
    entrada = Math.Truncate(valor / 3);
    restoDiv = (valor % 3) / 2;
    parcela = entrada + restoDiv;
    Console.WriteLine("Entrada: " + entrada);
    Console.WriteLine("1x: " + parcela);
    Console.WriteLine("2x: " + parcela);
}
*/
//-----------------------------------------------------------------------------------------------------------
/*
10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que 
realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as 
notas de menor valor fossem distribuídas em número mínimo possível. 
Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, uma nota de R$ 20,00,
uma nota de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. 
Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas 
de acordo com o critério da “distribuição ótima”.
double valorSaque, numNotas200, numNotas100, numNotas50, numNotas20, numNotas10, numNotas5, numNotas2, sobra;


Console.WriteLine("Digite o valor do saque: ");
valorSaque = double.Parse(Console.ReadLine());
sobra = valorSaque;
if (valorSaque >= 200)
{
    numNotas200 = Math.Truncate(valorSaque / 200);
    sobra = valorSaque % 200;
    Console.WriteLine("Quantidade de notas de R$ 200: " + numNotas200);
}
if (sobra >= 100)
{
    numNotas100 = Math.Truncate(sobra / 100);
    sobra = sobra % 100;
    Console.WriteLine("Quantidade de notas de R$ 100: " + numNotas100);

}
if (sobra >= 50)
{
    numNotas50 = Math.Truncate(sobra / 50);
    sobra = sobra % 50;
    Console.WriteLine("Quantidade de notas de R$ 50: " + numNotas50);

}
if (sobra >= 20)
{
    numNotas20 = Math.Truncate(sobra / 20);
    sobra = sobra % 20;
    Console.WriteLine("Quantidade de notas de R$ 20: " + numNotas20);

}
if (sobra >= 10)
{
    numNotas10 = Math.Truncate(sobra / 10);
    sobra = sobra % 10;
    Console.WriteLine("Quantidade de notas de R$ 10: " + numNotas10);

}
if (sobra >= 5)
{
    numNotas5 = Math.Truncate(sobra / 5);
    sobra %= 5;
    Console.WriteLine("Quantidade de notas de R$ 5: " + numNotas5);

}
if (sobra >= 2)
{
    numNotas2 = Math.Truncate(sobra / 2);
    sobra %= 2;
    Console.WriteLine("Quantidade de notas de R$ 2: " + numNotas2);

}
*/
//-----------------------------------------------------------------------------------------------------------
/*
 11) Escreva um algoritmo para ler o número de eleitores de um município, o número de votos brancos, nulos e válidos. 
Calcule e escreva o percentual que cada um  representa em relação ao total de eleitores.
 
int votosBrancos, votosNulos, votosValidos, soma;
float percentualBrancos, percentualNulos, percentualValidos;
Console.WriteLine("Informe a quantidae de votos em Brancos: ");
votosBrancos = int.Parse(Console.ReadLine());
Console.WriteLine("Informe a quantidade de votos Nulos: ");
votosNulos = int.Parse(Console.ReadLine());
Console.WriteLine("Informe a quantidade de votos Válidos: ");
votosValidos = int.Parse(Console.ReadLine());

soma = votosBrancos + votosNulos + votosValidos;

percentualBrancos = (votosBrancos * 100) / soma;
percentualNulos = (votosNulos * 100) / soma;
percentualValidos = (votosValidos * 100) / soma;

Console.WriteLine("Percentual de votos em branco: " + percentualBrancos + "%");
Console.WriteLine("Percentual de votos Nulos: " + percentualNulos + "%");
Console.WriteLine("Percentual de votos válidos: " + percentualValidos + "%");
*/
//-----------------------------------------------------------------------------------------------------------
/*
 12) Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do combustível é de R$6,90, escreva um 
algoritmo para ler a marcação do odômetro (marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de 
combustível gasto e o valor total (R$) recebido dos passageiros. Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.

Fórmulas: Total quilometragem =  marcação odômetro final do dia - marcação odômetro inicio do dia 

Média do consumo = Total quilometragem/ quantidade de combustível gasto

Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)

int odometroInicio, odometroFinal, combustivelGastos, valorTotalPassageiros, KmTotal, mediaConsumo;
double lucro;

Console.WriteLine("Informe o odômetro inicial: ");
odometroInicio = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o odômetro final: ");
odometroFinal = int.Parse(Console.ReadLine());
Console.WriteLine("Quantidade de combustivel gasto: ");
combustivelGastos = int.Parse(Console.ReadLine());
Console.WriteLine("Valor total recebidos dos passageiros: ");
valorTotalPassageiros = int.Parse(Console.ReadLine());

KmTotal = odometroFinal - odometroInicio;
mediaConsumo = KmTotal / combustivelGastos;
lucro = valorTotalPassageiros - (combustivelGastos * 6.9);

Console.WriteLine("Quilometros totais percorridos: " + KmTotal);
Console.WriteLine("Consumo médio de combustível: " + mediaConsumo);
Console.WriteLine("Lucro obtido: " + lucro);
*/
//-----------------------------------------------------------------------------------------------------------
/*
 13) Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o 
preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas 
vendidas pelo vendedor, calcule e mostre: o salário do empregado

Console.WriteLine("Informe o valor do salário mínimo: ");
double salarioMinimo = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o preço de custo de cada bicicleta: ");
double precoCustoBicicleta = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o número de bicicletas vendidas pelo vendedor: ");
int numeroBicicletasVendidas = int.Parse(Console.ReadLine());

double comissao = 0.15 * precoCustoBicicleta * numeroBicicletasVendidas;
double salarioEmpregado = 2 * salarioMinimo + comissao;

Console.WriteLine("Salário do empregado: " + salarioEmpregado);
*/