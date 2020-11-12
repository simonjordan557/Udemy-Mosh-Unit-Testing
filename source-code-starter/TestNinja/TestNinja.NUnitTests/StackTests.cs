using NUnit.Framework;
using System;
using System.Reflection.Metadata.Ecma335;
using TestNinja.Fundamentals;

namespace TestNinja.NUnitTests
{
    class StackTests
    {
        Stack<int?> intStack;
        int previousCount;

        [SetUp]
        public void SetUp()
        {
            intStack = new Stack<int?>();
            previousCount = 0;
        }

        [Test]
        public void Stack_PushNullObject_ThrowsException()
        {
            int? nullObject = null;

            Assert.That(() => intStack.Push(nullObject), Throws.ArgumentNullException);
        }

        [Test]
        
        public void Stack_ListIsEmpty_PeekThrowsException()
        {
            Assert.That(() => intStack.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void Stack_ListIsEmpty_PopThrowsException()
        {
            Assert.That(() => intStack.Pop(), Throws.InvalidOperationException);
        }

        [Test] 
        public void Stack_ListIsEmpty_CountPropertyReturnsZero()
        {
            Assert.That(intStack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Stack_CallPushMethodValidObject_SuccesfullyAddsObject()
        {
            intStack.Push(1);
            Assert.That(intStack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Stack_CallPeekMethod_SuccessfullyReturnsLastObject()
        {
            intStack.Push(7);
            var result = intStack.Peek();
            Assert.That(result, Is.EqualTo(7));
        }

        [Test]
        public void Stack_CallPeekMethod_DoesntRemoveAnyObjects()
        {
            intStack.Push(7);
            previousCount = intStack.Count;
            _ = intStack.Peek();
            Assert.That(previousCount, Is.EqualTo(intStack.Count));
        }

        [Test]
        public void Stack_CallPopMethodValidStack_SuccessfullyReturnsLastObject()
        {
            intStack.Push(7);
            intStack.Push(6);
            intStack.Push(8);

            var result = intStack.Pop();

            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void Stack_CallPopMethodValidStack_SuccessfullyRemovesLastObject()
        {

            intStack.Push(11);
            intStack.Push(32);
            intStack.Push(9);
            previousCount = intStack.Count;

            _ = intStack.Pop();
            Assert.That(intStack.Count, Is.LessThan(previousCount));
        }
    }
}
