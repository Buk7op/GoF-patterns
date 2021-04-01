namespace FactoryMethod
{
    class ConcreteProduct : Product
    {
        public ConcreteProduct()
        {
            System.Console.WriteLine("Конкретный продукт создан");
        }
    }
}