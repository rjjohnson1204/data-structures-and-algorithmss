using System;
using Xunit;
using StacksAndQueues.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void MakingNodes()
        { // test to see if nodes are being created
            Node five = new Node(5);
            Assert.Equal(5, (int)five.Value);

            Node nine = new Node(9);
            Assert.Equal(9, (int)nine.Value);

            Node seven = new Node(7);
            Assert.Equal(7, (int)seven.Value);
        }

        [Fact]
        public void PushTest()
        {   // test to see if a new node top node
            Node node = new Node(1);
            Stack test = new Stack(node);

            test.Push(3);
            Assert.True(test.Top.Value == 3);

            test.Push(5);
            Assert.True(test.Top.Value == 5);

            test.Push(7);
            Assert.True(test.Top.Value == 7);

        }

        [Fact]
        public void PopTest()
        {
            Stack stack = new Stack();

            stack.Push(9);
            stack.Push(4);
            stack.Push(2);

            stack.Pop();

            Assert.Equal(2, stack.Top.Value);


        }
  
        [Fact]
        public void PeekTest()
        {

        }

        [Fact]
        public void EnqueueTest()
        {

        }

        [Fact]
        public void DequequeTest()
        {

        }

        [Fact]
        public void QueuePeekTest()
        {

        }
    }
}
