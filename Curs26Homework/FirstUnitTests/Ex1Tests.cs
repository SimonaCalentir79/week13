using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstUnitTests
{
    [TestFixture]
    public class Ex1Tests
    {
        private Curs26Homework.Reverse rev;

        [SetUp]
        public void Setup()
        {
            rev = new Curs26Homework.Reverse();
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("Test performed!");
        }

        [Test]//metoda marcata ca fiind unit test
        public void ReversedTest()
        {
            //arrange
            var input = "ab-cd";
            var expected = "dc-ba";

            //act
            var actual = rev.ReverseString(input);

            //assert
            Assert.AreEqual(expected,actual);
        }

        [TestCase("ab-cd", ExpectedResult ="dc-ba")]
        [TestCase("a-bC-dEf-ghIj", ExpectedResult = "j-Ih-gfE-dCba")]
        [TestCase("Test1ng-Leet=code-Q!", ExpectedResult = "Qedo1ct-eeLg=ntse-T!")]
        public string ReverseTestCases(string s)
        {
            //arrange
            var input = s;

            //act
            return rev.ReverseString(input);
        }

        [Test]
        public void ThrowExceptionWhenInputIsEmpty()
        {
            //arrange
            var input = "";

            //act & assert
            Assert.Throws<InvalidOperationException>(() => rev.ReverseString(input));
        }

        [Test]
        public void ThrowExceptionWhenInputIsNull()
        {
            //arrange
            string input = null;

            //act&assert
            Assert.Throws(typeof(InvalidOperationException), () => rev.ReverseString(input));
        }
    }
}
