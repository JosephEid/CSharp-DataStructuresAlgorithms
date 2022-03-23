using System;
using DataStructuresAlgorithms.DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructuresAlgorithmsTests.DataStructures
{
    [TestClass]
    public class QueueTests

    {
        [TestMethod]
        public void CanQueueValidValue()
        {
            Queue queue = new Queue(5);

            Assert.AreEqual(-1, queue.Front);
            Assert.AreEqual(-1, queue.Back);

            queue.Enqueue(5);

            Assert.AreEqual(0, queue.Front);
            Assert.AreEqual(0, queue.Back);

            Assert.AreEqual(5, queue.GetVal(0));
        }

        [TestMethod]
        public void CannotExceedQueueSize()
        {
            Queue queue = new Queue(2);

            Assert.AreEqual(-1, queue.Front);
            Assert.AreEqual(-1, queue.Back);

            queue.Enqueue(5);
            queue.Enqueue(5);

            Assert.AreEqual(0, queue.Front);
            Assert.AreEqual(1, queue.Back);

            queue.Enqueue(5);
            Assert.AreEqual(1, queue.Back); //queue back should still be 1
        }

        [TestMethod]
        public void DequeueReturnsExpectedValue()
        {
            Queue queue = new Queue(2);

            queue.Enqueue(2);
            queue.Enqueue(5);

            Assert.AreEqual(2, queue.Dequeue());
            Assert.AreEqual(0, queue.GetVal(0));
            Assert.AreEqual(1, queue.Front);
        }

        [TestMethod]
        public void CannotDequeueEmptyQueue()
        {
            Queue queue = new Queue(5);

            queue.Enqueue(3);
            queue.Enqueue(5);
            queue.Dequeue();
            queue.Dequeue();
            Assert.AreEqual(0, queue.Dequeue());

            Assert.AreEqual(-1, queue.Front);
            Assert.AreEqual(-1, queue.Back);
        }
    }
}
