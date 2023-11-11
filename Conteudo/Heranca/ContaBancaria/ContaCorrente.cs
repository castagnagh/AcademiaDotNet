using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    internal class ContaCorrente : ContaBancaria
    {
        private int _qtd = 0;

        public override void Sacar(double valor)
        {
            if (_qtd > 0)
            {
                Saldo = Saldo - valor + 0.05;
            }
            else
            {
                Saldo = Saldo - valor;
            }
            _qtd++;
        }

        public override void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine("O saldo é: " + Saldo);
        }
    }

}
