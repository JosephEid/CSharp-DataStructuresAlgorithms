using System;
namespace DataStructuresAlgorithms.DataStructures
{
    public class Queue
    {
        public Queue(int size)
        {
            Array = new int[size];
            Front = -1;
            Back = -1;
            Max = size;
        }

        public int[] Array { get; private set; }
        public int Front { get; private set; }
        public int Back { get; private set; }
        public int Max { get; private set; }

        public void Enqueue(int val)
        {
            if (Back + 1 == Max)
            {
                Console.WriteLine("queue full");
                return;
            }

            Back++;

            if (Front == -1) Front++;

            Array[Back] = val;
        }

        public int Dequeue()
        {
            if (Front > Back || Back == -1)
            {
                Console.WriteLine("Queue Empty");
                Front = -1;
                Back = -1;
            }
            if (Front >= 0)
            {
                int val = Array[Front];
                Array[Front] = default;
                Front++;

                return val;
            }

            return 0;
        }

        public int GetVal(int v)
        {
            return Array[v];
        }
    }
}
