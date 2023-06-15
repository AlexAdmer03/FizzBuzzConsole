using FizzBuzzConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace TestTDD
{
    [TestClass]
    public class TestBuzz
    {
        private Logic sut;

        [TestInitialize]
        public void Setup()
        {
            sut = new Logic();
        }

        [TestMethod]
        public void FizzBuzz_ReturnsBuzz_WhenNumberIsDivisibleByFive()
        {
            var result = sut.FizzBuzz(5);
            Assert.AreEqual("Buzz", result);
        }
    }
}

