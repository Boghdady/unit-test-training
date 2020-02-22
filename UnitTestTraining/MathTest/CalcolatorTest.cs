
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestTraining.Math;

namespace UnitTestTraining
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void ShouldRetrunFactorilForNumber()
        {
            // 1) Preparing => Create instance
            var classUnderTest = new Calculator();
            var expected = 120;

            // 2) Implementation => Call method that represent tested behavior
            var acual= classUnderTest.Factorial(5);

            // 3) Checking => Check the acual result equal the expected result
            Assert.AreEqual(expected, acual);
        }

        [TestMethod]
        public void shuoldReturnFactorialOf_0()
        {
            // 1) Preparing => Create instance
            var systemUnderTest = new Calculator();
            var expected = 1;

            // 2) Implementation =>  Call method that represent tseted behavior
            var actual = systemUnderTest.Factorial(0);

            // 3) Checking => Check the acual result equal the expected result
            Assert.AreEqual(expected, actual);

        }

        // Test Through exceptions
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]

        public void shouldResturnInvalidOperationException()
        {
            var target = new Calculator();

            target.Factorial(-1);
            Assert.Fail("Expected exception not thrown");
        }

    }
}
