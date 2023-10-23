namespace AulaFuncoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Oi pessoal, neste exemplo irei apresentar funções");
            //apresentaMensagem();

            //lerDoisNum();
            double num1, num2;
            Console.WriteLine("Digite dois numeros: ");
            num1 = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());
            somarDoisNum(num1, num2);
        }

        //static void lerDoisNum()
        //{
        //    Console.WriteLine("Digite dois números: ");
        //    num1 = double.Parse(Console.ReadLine());
        //    num2 = double.Parse(Console.ReadLine());
        //}
        static void somarDoisNum(double num1, double num2)
        {
            double resultado;
            resultado = num1 + num2;
            Console.WriteLine("O resultado da soma é igual: " + resultado);
        }
        static void apresentaMensagem()
        {
            Console.WriteLine("Eu estou aqui na função");
        }
    }
}