using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteFlyweight concreteFlyweight = new ConcreteFlyweight();
            UnsharedObject1 unsharedObject1 = new UnsharedObject1(concreteFlyweight);
            UnsharedObject1 unsharedObject2 = new UnsharedObject1(concreteFlyweight);

            unsharedObject1.Method("Работа первого объекта через flyweight");
            unsharedObject2.Method("Работа второго объекта через flyweight");

            
        }
    }
}
