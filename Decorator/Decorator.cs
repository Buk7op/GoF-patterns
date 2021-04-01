namespace Decorator
{
    abstract class Decorator : Component
    {
        public Component component { protected get; set; }

        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
        
    }
}