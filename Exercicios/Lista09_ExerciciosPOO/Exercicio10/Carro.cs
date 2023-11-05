using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exercicio10
{
    internal class Carro
    {
        public string modelo;
        public int ano;
        public int velocidade = 0;

        public void acelerarCarro()
        {
            velocidade += 10;
            Console.WriteLine(velocidade); 
        }

        public void diminuirVelocidade()
        {
            if(velocidade <= 0)
            {
                Console.WriteLine("Velocidade está em 0, não pode ser diminuida");
                return;
            } else
            {
                velocidade -= 10;
                Console.WriteLine(velocidade);
            }
        }
    }
}
