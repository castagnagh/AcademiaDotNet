using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    internal class ContaPoupanca : ContaBancaria
    {
        public override void Sacar(double valor)
        {
            Saldo = Saldo - (valor + 0.10);
            Console.WriteLine("");
        }
    }
}
