using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    internal class Moto : Veiculo
    {
        public int Cilindradas { get; set; }

        public Moto(string marca, int ano, int cc) : base(marca, ano)
        {
            Cilindradas = cc;
        }

        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine("Cilindradas: " + Cilindradas);
        }
    }
}
