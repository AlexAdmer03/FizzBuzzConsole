using FizzBuzzConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFizzBuzzConsole
{
    [TestClass]
    public class TestFizzBuzz
    {
        private Logic logic = new Logic();

        [TestMethod]
        public void TestFizzBuzzWithDivisibleBy3()
        {
            Assert.AreEqual("Fizz", logic.FizzBuzz(3));
        }

        [TestMethod]
        public void TestFizzBuzzWithDivisibleBy5()
        {
            Assert.AreEqual("Buzz", logic.FizzBuzz(5));
        }

        [TestMethod]
        public void TestFizzBuzzWithDivisibleBy3And5()
        {
            Assert.AreEqual("FizzBuzz", logic.FizzBuzz(15));
        }

        [TestMethod]
        public void TestFizzBuzzWithNotDivisibleBy3Or5()
        {
            Assert.AreEqual("7", logic.FizzBuzz(7));
        }
    }
}
