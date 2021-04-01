using System.Collections;

namespace Composite
{
    class Composite : Component
    {
        ArrayList nodes = new ArrayList();
        public Composite(string name) : base(name)
        {
        }

        public override void Add(Component c)
        {
            nodes.Add(c);
        }

        public override Component GetChild(int index)
        {
            return nodes[index] as Component;
        }

        public override void Operation()
        {
            System.Console.WriteLine("This is " + name);
            foreach(Component c in nodes)
            {
                c.Operation();
            }
        }

        public override void Remove(Component c)
        {
            nodes.Remove(c);
        }
    }
}