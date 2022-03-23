using System;
namespace DataStructuresAlgorithms.DataStructures
{
    public class Stack
    {
        public Stack(int size)
        {
            Array = new int[size];
            Top = -1;
            Max = size;
        }

        public int[] Array { get; private set; }
        public int Top { get; private set; }
        public int Max { get; private set; }

        public void Push(int val)
        {
            Top += 1;

            if (Top >= Max)
            {
                throw new StackOverflowException();
            }

            Array[Top] = val;
        }

        public int Pop()
        {
            if (Top < 0)
            {
                Console.WriteLine("Stack underflow");
                return default;
            }

            int val = Array[Top];
            Array[Top] = default;
            Top -= 1;
            return val;
        }
        
        public int GetVal(int v)
        {
            return Array[v];
        }
    }
}
