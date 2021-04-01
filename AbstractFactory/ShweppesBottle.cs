namespace AbstractFactory
{
    class SchweppesBottle : AbstractBottle
    {
        public override void Interact(AbstractWater water)
        {
            System.Console.WriteLine(this + " interact " + water);
        }

        public override void Interact(AbstractCover cover)
        {
            System.Console.WriteLine(this + " interact " + cover);
        }

        public override void Interact(AbstractLabel label)
        {
            System.Console.WriteLine(this + " interact " + label);
        }
    }
}