namespace Adapter_class_
{
    class Adapter : Adaptee, ITarget
    {
        public void Request()
        {
            base.SpecificRequest();
        }
    }
}