using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject subject = new ConcreteSubject();
            subject.State = "Мурзилка";

            ConcreteObserver observer = new ConcreteObserver(subject,"Вася");
            subject.Attach(observer);
            subject.Notify();

            System.Console.WriteLine($"{observer.Name} подписан на журнал {observer.ObserverState}");
        }
    }
}
