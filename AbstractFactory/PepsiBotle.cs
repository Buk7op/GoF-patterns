namespace AbstractFactory
{
    class PepsiBottle : AbstractBottle
    {
        public override void Interact(AbstractWater water)
        {
            System.Console.WriteLine(this +" interact with " + water);
        }

        public override void Interact(AbstractCover cover)
        {
            System.Console.WriteLine(this +" interact with " + cover);
        }

        public override void Interact(AbstractLabel label)
        {
            System.Console.WriteLine(this +" interact with " + label);
        }
    }
}