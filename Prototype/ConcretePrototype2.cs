namespace Prototype
{
    class ConcretePrototype2 : Prototype
    {

        public ConcretePrototype2(int id) : base(id)
        {
            
        }
        public override Prototype Clone() => new ConcretePrototype2(Id);
        
    }
}