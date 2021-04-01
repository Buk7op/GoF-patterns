using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Component component = new ConcreteComponent();
            Decorator decorA = new ConcreteDecoratorA();
            Decorator decorB = new ConcreteDecoratorB();

            decorA.component = component;
            decorB.component = decorA;
            decorB.Operation();
        }
    }
}
