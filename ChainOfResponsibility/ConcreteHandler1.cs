namespace ChainOfResponsibility
{
    class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request == 1)
            {
                System.Console.WriteLine("One");
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}