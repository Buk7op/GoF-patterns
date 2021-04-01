using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Component root = new Composite("Root");
            Component branch1 = new Composite("Branch 1");
            Component branch2 = new Composite("Branch2");
            Component leaf1 = new Leaf("Leaf 1");
            Component leaf2 = new Leaf("Leaf 2");

            root.Add(branch1);
            root.Add(branch2);
            branch1.Add(leaf1);
            branch2.Add(leaf2);
            root.Operation();
        }
    }
}
