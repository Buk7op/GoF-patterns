using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Enumerable enumerable = new Enumerable();
            
            enumerable[0] = "Object A";
            enumerable[1] = "Object B";
            enumerable[2] = "Object C";
            enumerable[3] = "Object D";

            foreach (var item in enumerable)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
