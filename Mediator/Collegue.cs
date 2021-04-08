namespace Mediator
{
    abstract class Collegue
    {
        protected Mediator mediator;
        public Collegue(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }
}