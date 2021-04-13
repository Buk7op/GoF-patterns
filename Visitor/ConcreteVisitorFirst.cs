namespace Visitor
{
    class ConcreteVisitorFirst : Visitor
    {
        public override void VisitA(ConcreteElementA concreteElementA)
        {
            concreteElementA.OperationA();
        }

        public override void VisitB(ConcreteElementB concreteElementB)
        {
            concreteElementB.OperationB();
        }
    }
}