using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO
{
    internal class Lampada
    {
        public bool ligada;
        public double potencia;

        public void Ligar()
        {
            Console.WriteLine("Ligando Lampada!");
            ligada = true;
        }
        public void Desligar()
        {
            Console.WriteLine("Desligando Lampada!");
            ligada = false;
        }
        public bool EstaLigada()
        {
            return ligada;
        }
    }
}
