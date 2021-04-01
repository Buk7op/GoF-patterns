using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton instance1 = Singleton.Instance();
            Singleton instance2 = Singleton.Instance();
            System.Console.WriteLine(ReferenceEquals(instance1,instance2));
        }
    }
}
