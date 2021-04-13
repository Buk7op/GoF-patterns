namespace Visitor
{
    abstract class Visitor
    {
        public abstract void VisitA(ConcreteElementA concreteElementA);
        public abstract void VisitB(ConcreteElementB concreteElementB);
    }
}