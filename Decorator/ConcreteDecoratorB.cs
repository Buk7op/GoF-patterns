namespace Decorator
{
    class ConcreteDecoratorB : Decorator
    {
        string addedState = "Поле декоратора";

        public override void Operation()
        {
            base.Operation();
            System.Console.WriteLine(addedState);
        }
    }
}