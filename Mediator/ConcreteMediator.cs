namespace Mediator
{
    class ConcreteMediator : Mediator
    {
        public ConcreteCollegue1 Collegue1 { get; set; }
        public ConcreteCollegue2 Collegue2 { get; set; }
        public override void Send(string message, Collegue collegue)
        {
            if(Collegue1 == collegue)
            {
                Collegue2.Notify(message);
            }
            else
            {
                Collegue1.Notify(message);
            }
        }
    }
}