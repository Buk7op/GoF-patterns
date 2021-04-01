using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Prototype prototype = new ConcretePrototype(1);
            Prototype clone = prototype.Clone();
            System.Console.WriteLine(prototype.Id + " proto");
            System.Console.WriteLine(clone.Id + " Clone");
        }
    }
}
