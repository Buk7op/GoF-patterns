using System.Collections;

namespace Iterator
{
    class Enumerator : IEnumerator
    {
        private Enumerable enumerable;
        private int current = -1;
        public Enumerator(Enumerable enumerable)
        {
            this.enumerable = enumerable;
        }
        public object Current => enumerable[current];

        public bool MoveNext()
        {
            if (current < enumerable.Count - 1)
            {
                current++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            current = -1;
        }
    }
}