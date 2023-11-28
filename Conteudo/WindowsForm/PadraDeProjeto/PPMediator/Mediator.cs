using PadraDeProjeto.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraDeProjeto.PPMediator
{
    public abstract class Mediator
    {
        public abstract void Enviar(string mensagem, Colega colega);
    }
}
