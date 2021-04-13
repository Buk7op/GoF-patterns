namespace Visitor
{
    class ConcreteElementA : Element
    {
        public override void Accept(Visitor visitor)
        {
            if(visitor is ConcreteVisitorFirst)
                visitor.VisitA(this);
        }
        public void OperationA()
        {
            System.Console.WriteLine("Operation A on element A by first visitor");
        }
    }
}