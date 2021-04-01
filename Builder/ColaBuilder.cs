namespace Builder
{
    class ColaBuilder : AbstractBuilder
    {
        Drink drink = new Drink();
        public override void BuildBottle()
        {
            drink.Add(new ColaBottle());
        }

        public override void BuildCover()
        {
            drink.Add(new ColaCover());
        }

        public override void BuildWater()
        {
            drink.Add(new ColaWater());
        }

        public override Drink GetResult()
        {
            return drink;
        }
    }
}