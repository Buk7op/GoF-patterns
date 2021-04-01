namespace AbstractFactory
{
    abstract class AbstractBottle
    {
        public abstract void Interact(AbstractWater water);
        public abstract void Interact(AbstractCover cover);
        public abstract void Interact(AbstractLabel label);
    }
}