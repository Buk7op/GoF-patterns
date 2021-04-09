using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Context contextA = new Context(new ConcreteStrategyA());
            contextA.ContextInterface();

            Context contextB = new Context(new ConcreteStrategyB());
            contextB.ContextInterface();

            Context contextC = new Context(new ConcreteStrategyC());
            contextC.ContextInterface();
        }
    }
}
