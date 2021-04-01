namespace Flyweight
{
    class UnsharedObject2 : Flyweight
    {
        Flyweight flyweight;

        public UnsharedObject2(Flyweight flyweight)
        {
            this.flyweight = flyweight;
        }
        public override void Method(string txt)
        {
            flyweight.Method(txt);
        }
    }

}