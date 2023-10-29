/*14 - Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um 
link de Internet (em Mbps). Em seguida, calcule e informe o tempo aproximado de download 
do arquivo usando este link (em minutos).
*/
double tamanho, velocidade, tempo;

Console.WriteLine("Informe o tamanho de um arquivo (em MB): ");
tamanho = double.Parse(Console.ReadLine());
Console.WriteLine("Informe a velocidade da internet (em Mbps): ");
velocidade = double.Parse(Console.ReadLine());

tempo = tamanho / (velocidade / 8);

Console.WriteLine("O tempo que irá levar para realizar o Download será: " + tempo + " segundos.");
