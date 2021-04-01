namespace Decorator
{
    class ConcreteComponent : Component
    {
        public override void Operation()
        {
            System.Console.WriteLine("Работа компонента");;
        }
    }
}