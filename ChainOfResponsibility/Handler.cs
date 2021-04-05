namespace ChainOfResponsibility
{
    abstract class Handler
    {
        public Handler successor {  get; set; }
        public abstract void HandleRequest(int request);
        
    }
}