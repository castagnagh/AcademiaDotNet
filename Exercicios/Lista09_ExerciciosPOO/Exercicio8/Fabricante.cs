using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    internal class Fabricante
    {


        private string _nome;
        public string Endereco { get; set; }
        public string Cidade { get; set; }

        public Fabricante(string nome, string endereco, string cidade)
        {
            Nome = nome;
            Endereco = endereco;
            Cidade = cidade;
        }

        public Fabricante()
        {
           
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
    }
}
