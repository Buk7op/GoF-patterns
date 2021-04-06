namespace Command
{
    class Invoker
    {
        public Command Command { get;  set; }
        public void ExecuteCommand()
        {
            Command.Execute();
        }
        
    }
}