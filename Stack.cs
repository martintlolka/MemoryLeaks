namespace MemoryLeaks
{
    public class Stack
    {
        private object[] elements;
        private int size = 0;

        public Stack(int initialCapacity)
        { 
            // Check if array needs to be resized (Not part of the excecise)
            this.elements = new object[initialCapacity];
        }

        public void Push(object o)
        {
            this.elements[size++] = o;
        }

        public object Pop()
        {
            var top = this.elements[--size];

            // set popped item to null allows GC to collect popped object if its not in use.
            this.elements[size] = null;
            return top;
        }
    }
}
