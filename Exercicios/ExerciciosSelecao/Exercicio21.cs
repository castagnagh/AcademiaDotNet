/*21 - Crie um programa que permita que o usuário selecione uma unidade de medida de entrada (metros, centímetros, 
 * polegadas ou pés) e uma unidade de medida de saída usando um menu com o comando switch case. O programa deve, 
 * em seguida, pedir ao usuário um valor de entrada e converter esse valor para a unidade de saída selecionada.
 */
internal class Exercicio21
{
    private static void Main(string[] args)
    {
        char unidadeEntrada, unidadeSaida;
        double valor;
        Console.WriteLine("CONVERSOR DE UNIDADES DE MEDIDAS");
        Console.WriteLine("-----------MENU-----------");
        Console.WriteLine("1 - CENTIMETROS");
        Console.WriteLine("2 - METROS");
        Console.WriteLine("3 - POLEGADAS");
        Console.WriteLine("4 - PÉS");
        Console.WriteLine("Informe a unidade de entrada: ");
        unidadeEntrada = char.Parse(Console.ReadLine());
        Console.Write("Informe a unidade de saída: ");
        unidadeSaida = char.Parse(Console.ReadLine());
        Console.Write("Informe o valor de conversão: ");
        valor = double.Parse(Console.ReadLine());

        switch (unidadeEntrada)
        {
            case '1':
                if (unidadeSaida == '1')
                {
                    // Converte centímetros para centímetros
                    Console.WriteLine("O valor já esta na medida desejada! " + valor + "cm é " + valor + " cm");
                }
                else if (unidadeSaida == '2')
                {
                    // Converte centímetros para metros
                    Console.WriteLine(valor + " cm convertido para " + valor / 100 + " metros");
                }
                else if (unidadeSaida == '3')
                {
                    // Converte centímetros para polegadas
                    Console.WriteLine(valor + " cm convertido para " + valor / 2.54 + " polegadas");
                }
                else if (unidadeSaida == '4')
                {
                    // Converte centímetros para pés
                    Console.WriteLine(valor + " cm convertido para " + valor / 30.48 + " pés");
                }
                break;

            case '2':
                if (unidadeSaida == '1')
                {
                    // Converte metros para centímetros
                    Console.WriteLine(valor + " m convertido para " + valor * 100 + " centimetros");
                }
                else if (unidadeSaida == '2')
                {
                    // Converte metros para metros
                    Console.WriteLine("O valor já esta na medida desejada! " + valor + "m é " + valor + " m");
                }
                else if (unidadeSaida == '3')
                {
                    // Converte metros para polegadas
                    Console.WriteLine(valor + " m convertido para " + valor * 39.37 + " polegadas");
                }
                else if (unidadeSaida == '4')
                {
                    // Converte metros para pés
                    Console.WriteLine(valor + " m convertido para " + valor * 3.281 + " pés");
                }
                break;

            case '3':
                if (unidadeSaida == '1')
                {
                    // Converte polegadas para centímetros
                    Console.WriteLine(valor + " polegadas convertido para " + valor * 2.54 + " centimetros");
                }
                else if (unidadeSaida == '2')
                {
                    // Converte polegadas para metros
                    Console.WriteLine(valor + " polegadas convertido para " + valor * 39.37 + " metros");
                }
                else if (unidadeSaida == '3')
                {
                    // Converte polegadas para polegadas
                    Console.WriteLine("O valor já esta na medida desejada! " + valor + "polegadas é " + valor + " polegadas");
                }
                else if (unidadeSaida == '4')
                {
                    // Converte polegadas para pés
                    Console.WriteLine(valor + " polegadas convertido para " + valor / 12 + " pés");
                }
                break;

            case '4':
                if (unidadeSaida == '1')
                {
                    // Converte pés para centímetros
                    Console.WriteLine(valor + " pés convertido para " + valor * 30.48 + " centimetros");
                }
                else if (unidadeSaida == '2')
                {
                    // Converte pés para metros
                    Console.WriteLine(valor + " pés convertido para " + valor / 3.281 + " metros");
                }
                else if (unidadeSaida == '3')
                {
                    // Converte pés para polegadas
                    Console.WriteLine(valor + " pés convertido para " + valor * 12 + " polegadas");
                }
                else if (unidadeSaida == '4')
                {
                    // Converte pés para pés
                    Console.WriteLine("O valor já esta na medida desejada! " + valor + "pés é " + valor + " pés");
                }
                break;

            default:
                Console.WriteLine("Unidade de entrada inválida.");
                break;
        }
    }
}