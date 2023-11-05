using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    internal class Animal
    {
        private string _nome;
        private string _especie;
        private string _idade;

        public string Nome { get { return _nome; } set { _nome = value; } } 
        public string Especie { get { return _especie; } set { _especie = value; } }

        public string Idade { get { return _idade; } set { _idade = value; } }

        public void EmitirSom(string op)
        {
            if(op == "1")
            {
                Console.Clear();
                Console.WriteLine("Miau");
            } else if (op == "2") 
            {
                Console.Clear();
                Console.WriteLine("Auau"); 
            }
            else if(op == "3") 
            {
                Console.Clear();
                Console.WriteLine("Méééé"); 
            } 
            else if(op == "4") 
            {
                Console.Clear();
                Console.WriteLine("Muuuuuu");
            }
        }
    }
}
