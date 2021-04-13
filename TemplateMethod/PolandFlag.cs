using System;
namespace TemplateMethod
{
    class PolandFlag : DrawFlag
    {
        protected override void DrawBottomPart()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(new string(' ',8));
        }

        protected override void DrawTopPart()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(new string(' ',8));
        }
    }
}