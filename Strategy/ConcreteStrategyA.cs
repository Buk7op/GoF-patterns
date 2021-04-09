namespace Strategy
{
    class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            System.Console.WriteLine("Strategy A in action");
        }
    }
}