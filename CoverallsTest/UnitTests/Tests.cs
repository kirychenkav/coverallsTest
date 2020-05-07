using System;
using CoverallsTest;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.True(true);
        }
        
        [Test]
        public void Test2()
        {
            var date = Program.GetCurrentDateString();
            Assert.IsNotEmpty(date);
        }
        
        [Test]
        public void FailTest()
        {
            var date = Program.GetCurrentDateString();
            Assert.IsNull(date);
        }
        
        [Test]
        public void FailTest2()
        {
            Assert.True(false);
        }
    }
}