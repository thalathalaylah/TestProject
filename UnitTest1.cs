using System;
using Xunit;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int a = 1 + 1;
            Assert.Equal(2, a);
        }
    }
}
