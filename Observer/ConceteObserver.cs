namespace Observer
{
    class ConcreteObserver : Observer
    {
        public string Name{get;private set;}
        public string ObserverState{get;private set;}
        private ConcreteSubject subject;
        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            this.Name = name;
            this.subject = subject;
        }
       

        public override void Update()
        {
            ObserverState = subject.State;
        }
    }
}