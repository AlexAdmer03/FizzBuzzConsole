using FizzBuzzConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTDD
{
    [TestClass]
    public class TestFizz
    {
        private Logic sut;

        [TestInitialize]
        public void Setup()
        {
            sut = new Logic();
        }

        [TestMethod]
        public void FizzBuzz_ReturnsFizz_WhenNumberIsDivisibleByThree()
        {
            var result = sut.FizzBuzz(3);
            Assert.AreEqual("Fizz", result);
        }
    }
}
