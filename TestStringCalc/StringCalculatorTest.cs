using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringCalculatorTests
{
    [TestClass]
    public class StringCalculatorTests
    {
        private StringCalculator _sut;

        [TestInitialize]
        public void Setup()
        {
            _sut = new StringCalculator();
        }

        [TestMethod]
        public void Add_EmptyString_ReturnsZero()
        {
            
            var result = _sut.Add("");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Add_SingleNumber_ReturnsTheNumber()
        {
            var result = _sut.Add("5");

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Add_MultipleNumbers_ReturnsSumOfNumbers()
        {
            var result = _sut.Add("1,2,3,4,5");

            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Add_NumbersLessThanZeroOrGreaterThanThousand_AreIgnored()
        {
            var result = _sut.Add("-1,2000,1000,3");

            Assert.AreEqual(1003, result);
        }
    }
}
