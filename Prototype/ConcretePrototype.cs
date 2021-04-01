namespace Prototype
{
    class ConcretePrototype : Prototype
    {

        public ConcretePrototype(int id) : base(id)
        {
            
        }
        public override Prototype Clone() => new ConcretePrototype(Id);
        
    }
}