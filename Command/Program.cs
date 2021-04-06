using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver();
            ConcreteCommand concreteCommand = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();
            
            invoker.Command = concreteCommand;
            invoker.ExecuteCommand();
        }
    }
}
