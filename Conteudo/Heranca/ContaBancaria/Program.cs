/**/
namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente();
            ContaPoupanca cp = new ContaPoupanca();

            cc.Depositar(100);
            cc.Sacar(100);

            cp.Depositar(100);
            cp.Sacar(100);
        }
    }
}