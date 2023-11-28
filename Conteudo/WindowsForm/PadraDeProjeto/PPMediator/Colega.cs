namespace PadraDeProjeto.PPMediator
{
    public abstract class Colega
    {
        protected Mediator _mediator;

        public Colega(Mediator mediator)
        {
            _mediator = mediator;
        }
    }
}