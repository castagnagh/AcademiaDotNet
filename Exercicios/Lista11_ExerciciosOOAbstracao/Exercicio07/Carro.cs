using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    internal class Carro : Veiculo
    {
        public int NumeroDePortas { get; set; } 

        public Carro(string marca, int ano, int numPortas) : base(marca, ano)
        {
            NumeroDePortas = numPortas; 
        }

        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine("Numero de portas: " + NumeroDePortas); 
        }
    }

}
