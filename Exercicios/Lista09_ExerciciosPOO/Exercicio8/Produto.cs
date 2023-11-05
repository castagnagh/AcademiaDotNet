using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    internal class Produto
    {
        private string _nomeProduto;
        private double _valor;
        public Fabricante fabricante;

        public Produto()
        {
            fabricante = new Fabricante();
        }

        public string NomeProduto
        {
            get { return _nomeProduto; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Nome do produto não pode ser vazio");
                }
                else
                {
                    _nomeProduto = value;
                }
            }
        }

        public double Valor
        {
            get { return _valor; }
            set { if(value < 0)
                {
                    Console.WriteLine("O produto não pode receber um valor negativo");
                } else
                {
                    _valor = value;
                } 
            }
        }
    }
}
