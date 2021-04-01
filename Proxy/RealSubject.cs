namespace Proxy
{
    class RealSubject : Subject
    {
        public override void Request()
        {
            System.Console.WriteLine("Работа субъекта");
        }
    }
}