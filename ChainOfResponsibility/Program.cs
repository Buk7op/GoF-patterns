using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteHandler1 handler1 = new ConcreteHandler1();
            ConcreteHandler2 handler2 = new ConcreteHandler2();

            handler1.successor = handler2;
            handler1.HandleRequest(1);
            handler1.HandleRequest(2);
        }
    }
}
