using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction abstraction;
            abstraction = new RefinedAbstraction(new ConcreteImp1());
            abstraction.Operation();

            abstraction = new RefinedAbstraction(new ConcreteImp2());
            abstraction.Operation();
        }
    }
}
