namespace Builder
{
    abstract class AbstractBuilder
    {
        public abstract void BuildBottle();
        public abstract void BuildWater();
        public abstract void BuildCover();

        public abstract Drink GetResult();
    }
}