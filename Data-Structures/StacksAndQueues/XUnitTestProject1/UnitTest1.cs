using System;
using Xunit;
using StacksAndQueues.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void MakingNodes()
        {
            Node five = new Node(5);
            Assert.Equal(5, (int)five.Value);

        }
    }
}
