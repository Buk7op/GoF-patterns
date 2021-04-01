namespace AbstractFactory
{
    class CocaColaWater : AbstractWater
    {
        private bool sugar;
        
        public CocaColaWater(bool sugar = true)
        {
            this.sugar = sugar;
        }
    }
}