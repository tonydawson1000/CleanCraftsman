namespace CleanCraftsman
{
    public class Stack
    {
        private int size = 0;
        private int[] elements = new int[2];

        public int GetSize()
        {
            return size;
        }

        public int Pop()
        {
            if (size == 0)
                throw new UnderflowException("Stack is Empty, Nothing to Pop");

            return elements[--size];
        }

        public void Push(int element)
        {
            this.elements[size++] = element;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }
    }

    public class UnderflowException : Exception
    {
        public UnderflowException() { }

        public UnderflowException(string message)
            : base(message) { }

        public UnderflowException(string message, Exception inner)
            : base(message, inner) { }
    }
}