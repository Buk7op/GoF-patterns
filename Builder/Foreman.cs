namespace Builder
{
    class Foreman
    {

        AbstractBuilder builder;
        public Foreman(AbstractBuilder builder)
        {
            this.builder = builder;
        }

        public void CreateDrink()
        {
            builder.BuildBottle();
            builder.BuildWater();
            builder.BuildCover();
        }
    }
}