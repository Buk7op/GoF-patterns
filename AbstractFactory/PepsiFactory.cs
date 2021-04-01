namespace AbstractFactory
{
    class PepsiFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new PepsiBottle();
        }

        public override AbstractCover CreateCover()
        {
            return new PepsiCover();
        }

        public override AbstractLabel CreateLabel()
        {
            return new PepsiLabel();
        }

        public override AbstractWater CreateWater()
        {
            return new PepsiWater();
        }

        public override AbstractWater CreateWater(bool sugar)
        {
            return new PepsiWater();
        }
    }
}