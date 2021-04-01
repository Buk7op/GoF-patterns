namespace Flyweight
{
    class ConcreteFlyweight : Flyweight
    {
        public override void Method(string txt)
        {
            System.Console.WriteLine(txt);
        }
    }
}