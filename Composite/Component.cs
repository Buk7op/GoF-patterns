namespace Composite
{
    abstract class Component
    {
        protected string name;
        public Component(string name)
        {
            this.name = name;
        }
        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract Component GetChild(int index);
        public abstract void Operation();
    }
}