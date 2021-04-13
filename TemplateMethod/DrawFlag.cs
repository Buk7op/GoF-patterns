namespace TemplateMethod
{
    abstract class DrawFlag
    {
        protected abstract void DrawTopPart();
        protected abstract void DrawBottomPart();
        public void Draw()
        {
            DrawTopPart();
            DrawBottomPart();
        }
    }
}