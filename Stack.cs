namespace MemoryLeaks
{
    public class Stack
    {
        private object[] elements;
        private int size = 0;

        public Stack(int initialCapacity)
        { 
            this.elements = new object[initialCapacity];
        }

        public void Push(object o)
        {
            this.elements[size++] = o;
        }

        public object Pop()
        {
            var top = this.elements[--size];
            this.elements[size] = null;
            return top;
        }
    }
}
