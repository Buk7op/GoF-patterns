namespace Bridge
{
    abstract class Abstraction
    {
        protected Implementor implementor;

        public Abstraction(Implementor implementor)
        {
            this.implementor = implementor;
        }
        public virtual void Operation()
        {
            implementor.OperationImp();
        }
    }
}
