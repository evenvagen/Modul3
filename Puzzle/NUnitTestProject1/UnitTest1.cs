using Puzzle;
using NUnit.Framework;


namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NewMethod() => Assert.AreNotEqual(30,0);
    }
}