using FizzBuzzStrategy;
using FizzBuzzStrategy.Impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzStrategyTest
{
    [TestClass]
    public class UnitTest1
    {
        private FizzBuzzContext _context;

        [TestInitialize]
        public void TestInitialize()
        {
            _context = new FizzBuzzContext();

            _context.Push(new FizzBuzzImpl());
            _context.Push(new FizzImpl());
            _context.Push(new BuzzImpl());
        }

        [TestMethod]
        public void TestMethod1()
        {

            Assert.AreEqual("1", _context.Echo(1));
            Assert.AreEqual("2", _context.Echo(2));
            Assert.AreEqual("Fizz", _context.Echo(3));
            Assert.AreEqual("4", _context.Echo(4));
            Assert.AreEqual("Buzz", _context.Echo(5));
            Assert.AreEqual("Fizz", _context.Echo(6));
            Assert.AreEqual("7", _context.Echo(7));
            Assert.AreEqual("8", _context.Echo(8));
            Assert.AreEqual("Fizz", _context.Echo(9));
            Assert.AreEqual("Buzz", _context.Echo(10));
            Assert.AreEqual("11", _context.Echo(11));
            Assert.AreEqual("Fizz", _context.Echo(12));
            Assert.AreEqual("13", _context.Echo(13));
            Assert.AreEqual("14", _context.Echo(14));
            Assert.AreEqual("FizzBuzz", _context.Echo(15));
            Assert.AreEqual("16", _context.Echo(16));
            Assert.AreEqual("17", _context.Echo(17));
            Assert.AreEqual("Fizz", _context.Echo(18));
            Assert.AreEqual("19", _context.Echo(19));
            Assert.AreEqual("Buzz", _context.Echo(20));

        }
    }
}
