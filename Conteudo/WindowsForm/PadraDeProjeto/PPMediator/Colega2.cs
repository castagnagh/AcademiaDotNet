using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraDeProjeto.PPMediator
{
    internal class Colega2 : Colega
    {
        public Colega2(Mediator mediator) : base(mediator)
        {
        }

        public void Enviar(string mensagem)
        {
            _mediator.Enviar(mensagem, this)
        }

        public void Notificar(string mensagem)
        {
            Console.WriteLine("Colega 2 recebeu a mensagem: " + mensagem);
        }
    }
}
