/*
 11 - Faça um programa no VS que receba uma hora, dividida em 2 variáveis (uma para hora e outra para minutos).
O programa deve exibir se a hora digitada está ou não válida. 
Lembre que usaremos o padrão de hora com 24h, de 0 a 23.*/
internal class Exercicio11
{
    private static void Main(string[] args)
    {
        int h, min;

        Console.WriteLine("Informe a hora: (h)");
        h = int.Parse(Console.ReadLine());
        while (h < 0 || h > 24)
        {
            Console.WriteLine("Hora inválida, digite uma hora de 1 a 24");
            h = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Informe os minutos: (min)");
        min = int.Parse(Console.ReadLine());
        while (min < 1 || min > 59)
        {
            Console.WriteLine("Minutos inválidos, digite um minuto de 1 a 59");
            min = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Hora digitada: " + h + "h" + min + "min");
    }
}