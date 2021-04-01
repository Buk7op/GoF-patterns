namespace AbstractFactory
{
    class CocaColaFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new CocaColaBottle();
        }

        public override AbstractCover CreateCover()
        {
            return new CocaColaCover();
        }

        public override AbstractLabel CreateLabel()
        {
            return new CocaColaLabel();
        }

        public override AbstractWater CreateWater()
        {
            return new CocaColaWater();
        }

        public override AbstractWater CreateWater(bool sugar)
        {
            return new CocaColaWater(sugar);
        }
    }
}
