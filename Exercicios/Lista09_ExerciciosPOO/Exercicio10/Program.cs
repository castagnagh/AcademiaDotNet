/*11 - Crie uma classe "Carro" com os atributos "modelo", "ano" e "velocidade".
 * Em seguida, crie um método para acelerar o carro (aumentando a velocidade em 10) 
 * e outro para frear o carro (diminuindo a velocidade em 10, mas nunca deixando a  velocidade negativa).*/
namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string op = "";
            Carro car = new Carro();
            do
            {
                Console.WriteLine(" 1 - acelerar");
                Console.WriteLine(" 2 - desacelerar");
                Console.WriteLine(" 3 - sair");
                Console.WriteLine("Opção: ");
                op = Console.ReadLine();

                if(op == "1")
                {
                    car.acelerarCarro();
                } else if(op == "2")
                {
                    car.diminuirVelocidade();
                }
            } while (op != "3");
        }
    }
}