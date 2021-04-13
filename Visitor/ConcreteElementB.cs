namespace Visitor
{
    class ConcreteElementB : Element
    {
        public override void Accept(Visitor visitor)
        {
            if(visitor is ConcreteVisitorSecond)
                visitor.VisitB(this);
        }
        public void OperationB()
        {
            System.Console.WriteLine($"Operation B on element B by second visitor");
        }
    }
}