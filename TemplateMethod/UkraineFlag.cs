using System;

namespace TemplateMethod
{
    class UkraineFlag : DrawFlag
    {
        protected override void DrawBottomPart()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string(' ',8));
        }

        protected override void DrawTopPart()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(new string(' ',8));
        }
    }
}