using repeated_word;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1RepeatedWord()
        {
            string test1 = "I have ten toes and ten fingers";


            Assert.Equal("ten", Program.RepeatedWord(test1));
            
        }

        [Fact]
        public void Test2RepeatedWord()
        {
            string test2 = "The care bears care";


            Assert.Equal("care", Program.RepeatedWord(test2));

        }
        [Fact]
        public void Test3RepeatedWord()
        {
            string test3 = ", ,";


            Assert.Equal(",", Program.RepeatedWord(test3));

        }

    }
}
