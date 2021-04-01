using System.Collections;

namespace Builder
{
    class Drink 
    {
        ArrayList parts = new ArrayList();
        public void Add(object part)
        {
            parts.Add(part);
        }
    }
}