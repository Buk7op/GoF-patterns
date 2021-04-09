using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new ConcreteStateA());
            System.Console.WriteLine(context.State);
            
            context.Request();
            System.Console.WriteLine(context.State);
            context.Request();
            System.Console.WriteLine(context.State);
        }
    }
}
