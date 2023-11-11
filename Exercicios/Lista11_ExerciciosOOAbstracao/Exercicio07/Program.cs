/*7 -
 a) Crie uma classe base chamada "Veiculo" com propriedades como "Marca" e "Ano."
 b) Crie classes derivadas como "Carro" e "Moto" que herdem de "Veiculo" e adicionem propriedades específicas, como "Número de Portas" para carros e "Cilindrada" para motos.
 c) Crie uma lista de Veículos que inclui instâncias de "Veiculo", "Carro" e "Moto." Use um loop para percorrer a lista e chamar um método "Apresentar" que exibe informações sobre cada veículo, demonstrando o polimorfismo.
 d) Modifique a classe "Veiculo" para ter um método virtual "Apresentar" que exiba informações gerais do veículo.
 e) Sobrescreva o método "Apresentar" nas classes derivadas para incluir informações específicas, como o número de portas para carros ou a cilindrada para motos.
*/
namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Veiculo> list = new List<Veiculo>();
            Carro c = new Carro("VW",2000, 2);
            Moto m = new Moto("Suzuki", 2005, 650);
            Veiculo v = new Veiculo("Ford", 2023);
            list.Add(v);
            list.Add(m);
            list.Add(c);

            foreach (Veiculo veiculo in list)
            {
                veiculo.Apresentar();
                Console.WriteLine();
            }

        }
    }
}