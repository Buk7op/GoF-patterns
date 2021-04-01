

namespace AbstractFactory
{
    class Client 
    {
        private AbstractWater water;
        private AbstractBottle bottle;
        private AbstractCover cover;
        private AbstractLabel label;

        public Client(AbstractFactory factory)
        {
            water = factory.CreateWater();
            bottle = factory.CreateBottle();
            cover = factory.CreateCover();
            label = factory.CreateLabel();
        }

        public void Run()
        {
            bottle.Interact(water);
            bottle.Interact(cover);
            bottle.Interact(label);
        }
    }
}