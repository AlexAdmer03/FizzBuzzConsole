using FizzBuzzConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTDD
{
    [TestClass]
    public class TestFizzBuzz
    {
        private Logic sut;

        [TestInitialize]
        public void Setup()
        {
            sut = new Logic();
        }

        [TestMethod]
        public void FizzBuzz_ReturnsFizzBuzz_WhenNumberIsDivisibleByThreeAndFive()
        {
            var result = sut.FizzBuzz(15);
            Assert.AreEqual("FizzBuzz", result);
        }
    }
}
