namespace Flyweight
{
    class UnsharedObject1 : Flyweight
    {
        Flyweight flyweight;

        public UnsharedObject1(Flyweight flyweight)
        {
            this.flyweight = flyweight;
        }
        public override void Method(string txt)
        {
            flyweight.Method(txt);
        }
    }

}