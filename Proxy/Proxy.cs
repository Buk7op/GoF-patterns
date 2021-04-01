namespace Proxy
{
    class Proxy : Subject
    {
        private RealSubject realSubject;
        public override void Request()
        {
            if(realSubject == null)
                realSubject = new RealSubject();
            realSubject.Request();
        }
    }
}