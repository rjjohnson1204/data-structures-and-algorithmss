using System;
using Xunit;
using LinkedList.Classes;
using LinkedList;

namespace TestForEnd
{
    public class UnitTest1
    {
        [Fact]
        public void PosFrmEnd1()
        {
            LList list = new LList();
            list.Insert(4);
            list.Insert(6);
            list.Insert(8);
            list.Insert(13);
            list.Insert(15);
            Assert.Equal(6, Program.PosFrmEnd(list.Head, 1));
        }
        [Fact]
        public void PosFrmEnd2()
        {
            LList list = new LList();
            list.Insert(4);
            list.Insert(6);
            list.Insert(8);
            list.Insert(13);
            list.Insert(15);
            Assert.Equal(4, Program.PosFrmEnd(list.Head, 0));
        }
        [Fact]
        public void PosFrmEnd3()
        {
            LList list = new LList();
            list.Insert(4);
            list.Insert(6);
            list.Insert(8);
            list.Insert(13);
            list.Insert(15);
            Assert.Equal(13, Program.PosFrmEnd(list.Head, 3));
        }
    }
}
