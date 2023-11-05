using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    internal class Musica
    {
        public string Nome { get; }
        public string Cantor { get; }
        public string Gravadora { get; }

        public Musica(string nome, string cantor, string gravadora)
        {
            Nome = nome;
            Cantor = cantor;
            Gravadora = gravadora;
        }
    }
}
