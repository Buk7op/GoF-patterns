using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator mediator = new ConcreteMediator();
            ConcreteCollegue1 collegue1 = new ConcreteCollegue1(mediator);
            ConcreteCollegue2 collegue2 = new ConcreteCollegue2(mediator);

            mediator.Collegue1 = collegue1;
            mediator.Collegue2 = collegue2;
            collegue1.Send("Hello from collegue 1");
            collegue2.Send("Hello from collegue 2");
        }
    }
}
