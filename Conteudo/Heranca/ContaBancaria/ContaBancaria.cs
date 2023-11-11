using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    internal class ContaBancaria
    {
        private double _saldo = 100;

        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        public virtual void Sacar(double valor)
        {
            _saldo -= valor;
        }

        public virtual void Depositar(double valor)
        {
            _saldo += valor;
        }
    }
}
