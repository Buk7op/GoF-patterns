namespace Decorator
{
    class ConcreteDecoratorA : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
        }

        private void AddedBehavior()
        {
            System.Console.WriteLine("Поведение декоратора");
        }
    }
}