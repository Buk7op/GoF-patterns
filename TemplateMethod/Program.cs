using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            UkraineFlag ukraineFlag = new UkraineFlag();
            ukraineFlag.Draw();
            System.Console.WriteLine();
            PolandFlag polandFlag = new PolandFlag();
            polandFlag.Draw();
            Console.ReadKey();
        }
    }
}
