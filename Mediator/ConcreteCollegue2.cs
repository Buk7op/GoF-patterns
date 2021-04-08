namespace Mediator
{
    class ConcreteCollegue2 : Collegue
    {
        public ConcreteCollegue2(Mediator mediator) : base(mediator)
        {
        }
        public void Notify(string message)
        {
            System.Console.WriteLine($"Notify message from collegue 2: {message}");
        }
        public void Send(string message)
        {
            mediator.Send(message,this);
        }
    }
}