using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    internal class Musica
    {
        static List<Musica> listaMusica = new List<Musica>();

        public string Nome { get; set; }
        public string Cantor {get; set;}
        public string Gravadora { get; set;}

        public Musica(string nome, string cantor, string gravadora)
        {
            Nome = nome;
            Cantor = cantor;
            Gravadora = gravadora;
        }
    }
}
