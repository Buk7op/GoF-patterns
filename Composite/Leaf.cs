using System;

namespace Composite
{
    class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Add(Component c)
        {
            throw new InvalidOperationException();
        }

        public override Component GetChild(int index)
        {
            throw new InvalidOperationException();
        }

        public override void Operation()
        {
            System.Console.WriteLine("This is " + name);
        }

        public override void Remove(Component c)
        {
            throw new InvalidOperationException();
        }
    }
}