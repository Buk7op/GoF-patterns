namespace Mediator
{
    class ConcreteCollegue1 : Collegue
    {
        public ConcreteCollegue1(Mediator mediator) : base(mediator)
        {
        }
        public void Notify(string message)
        {
            System.Console.WriteLine($"Notify message from collegue 1: {message}");
        }
        public void Send(string message)
        {
            mediator.Send(message,this);
        }
    }
}