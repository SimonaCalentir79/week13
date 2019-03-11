using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstUnitTests
{
    [TestFixture]
    public class Ex2Tests
    {
        private Curs26Homework.Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Curs26Homework.Calculator();
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("Test performed!");
        }

        [Test]//metoda marcata ca fiind unit test
        public void CalculatorSumTest()
        {
            //arrange
            var input1 = 60;
            var input2 = 20;
            var expected = 80;

            //act
            var actual = calc.Sum(input1, input2);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(25, 15, ExpectedResult = 40)]
        [TestCase(10.5, 14.6, ExpectedResult = 25.1)]
        [TestCase(25, 15.5, ExpectedResult = 40.50)]
        public dynamic CalculatorSumTestCases(dynamic a, dynamic b)
        {
            var A = a;
            var B = b;

            return calc.Sum(a, b);
        }

        [Test]
        public void CalculatorDeductionTest()
        {
            //arrange
            var input1 = 60;
            var input2 = 20;
            var expected = 40;

            //act
            var actual = calc.Deduct(input1, input2);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(25, 15, ExpectedResult = 10)]
        [TestCase(10.5, 14.6, ExpectedResult = -4.1)]
        [TestCase(25, 15.5, ExpectedResult = 9.50)]
        public dynamic CalculatorDeductionTestCases(dynamic a, dynamic b)
        {
            var A = a;
            var B = b;

            return calc.Deduct(a, b);
        }

        [Test]
        public void CalculatorMultiplyTest()
        {
            //arrange
            var input1 = 60;
            var input2 = 20;
            var expected = 1200;

            //act
            var actual = calc.Multiply(input1, input2);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(25, 15, ExpectedResult = 375)]
        [TestCase(10.5, 14.6, ExpectedResult = 153.29999999999998)]
        [TestCase(25, 15.5, ExpectedResult = 387.5)]
        public dynamic CalculatorMultiplyTestCases(dynamic a, dynamic b)
        {
            var A = a;
            var B = b;

            return calc.Multiply(a, b);
        }

        [Test]
        public void CalculatorDivideTest()
        {
            //arrange
            var input1 = 60;
            var input2 = 20;
            var expected = 3;

            //act
            var actual = calc.Divide(input1, input2);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(25, 10, ExpectedResult = 2)]
        [TestCase(10.5, 0.5, ExpectedResult = 21)]
        [TestCase(45, 1.5, ExpectedResult = 30)]
        public dynamic CalculatorDivideTestCases(dynamic a, dynamic b)
        {
            var A = a;
            var B = b;

            return calc.Divide(a, b);
        }
    }
}
