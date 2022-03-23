using System;
using DataStructuresAlgorithms.DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructuresAlgorithmsTests.DataStructures
{
    [TestClass]
    public class StackTests

    {
        [TestMethod]
        public void CanPushValidValueToStack()
        {
            Stack stack = new Stack(5);
            stack.Push(5);

            Assert.AreEqual(0, stack.Top);
            Assert.AreEqual(5, stack.GetVal(0));
        }

        [TestMethod]
        public void CannotExceedStackSize()
        {
            Stack stack = new Stack(2);
            stack.Push(5);
            stack.Push(5);

            Assert.AreEqual(1, stack.Top);
            Assert.ThrowsException<StackOverflowException>(() => stack.Push(5));
        }

        [TestMethod]
        public void PopReturnsExpectedValue()
        {
            Stack stack = new Stack(2);
            stack.Push(2);
            stack.Push(5);

            Assert.AreEqual(5, stack.Pop());
            Assert.AreEqual(0, stack.GetVal(1));
            Assert.AreEqual(0, stack.Top);
        }

        [TestMethod]
        public void CannotPopEmptyStack()
        {
            Stack stack = new Stack(2);

            Assert.AreEqual(0, stack.Pop());
            Assert.AreEqual(-1, stack.Top);
        }
    }
}
