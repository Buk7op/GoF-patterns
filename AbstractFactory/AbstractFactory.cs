namespace AbstractFactory
{
    abstract class AbstractFactory
    {
        public abstract AbstractWater CreateWater();
        public abstract AbstractWater CreateWater(bool sugar);
       
        public abstract AbstractBottle CreateBottle();

        public abstract AbstractCover CreateCover();

        public abstract AbstractLabel CreateLabel();
    }
}