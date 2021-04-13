namespace Visitor
{
    class ConcreteVisitorSecond : Visitor
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