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
        public void PushNewNodeToTop()
        {   // test to see if a new node is being pushed to the top
            Node node = new Node(1);
            Stack test = new Stack(node);

            test.Push(3);
            Assert.True(test.Top.Value == 3);

            test.Push(5);
            Assert.True(test.Top.Value == 5);

            test.Push(7);
            Assert.True(test.Top.Value == 7);

        }
    }
}
