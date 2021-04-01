using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            ColaBuilder builder = new ColaBuilder();
            Foreman foreman = new Foreman(builder);
            foreman.CreateDrink();
            Drink d = builder.GetResult();
        }
    }
}
