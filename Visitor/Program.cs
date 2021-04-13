using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectStructure objectStructure = new ObjectStructure();
            objectStructure.Attach(new ConcreteElementA());
            objectStructure.Attach(new ConcreteElementB());
            objectStructure.Accept(new ConcreteVisitorFirst());
            objectStructure.Accept(new ConcreteVisitorSecond());
        }
    }
}
