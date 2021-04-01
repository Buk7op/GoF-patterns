namespace AbstractFactory
{
    class SchweppesFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new SchweppesBottle();
        }

        public override AbstractCover CreateCover()
        {
            return new SchweppesCover();
        }

        public override AbstractLabel CreateLabel()
        {
            return new SchweppesLabel();
        }

        public override AbstractWater CreateWater()
        {
            return new SchweppesWater();
        }

        public override AbstractWater CreateWater(bool sugar)
        {
            throw new System.NotImplementedException();
        }
    }
}