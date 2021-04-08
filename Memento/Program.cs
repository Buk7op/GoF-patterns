using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            originator.State = "on";

            CareTaker careTaker = new CareTaker();
            careTaker.Memento = originator.CreateMemento();
            System.Console.WriteLine(originator.State);
            originator.State = "off";
            System.Console.WriteLine(originator.State);
            originator.SetMemento(careTaker.Memento);
            System.Console.WriteLine(originator.State);
        }
    }
}
