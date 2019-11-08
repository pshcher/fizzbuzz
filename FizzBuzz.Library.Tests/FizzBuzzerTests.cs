using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz.Library;

namespace FizzBuzz.Library.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        [Test]
        public void Bizzer_When1_Returns1()
        {
            // Arrange
            var input = 1;

            // Act
            string output = FizzBuzzer.GetValue(input);

            // Assert
            Assert.AreEqual("1", output);
        }

        [Test]
        public void Bizzer_When_qweqw_Returns2()
        {
            // Arrange
            var input = "qweqw";

            // Act
            int output = FizzBuzzer.FirstUnique(input);

            // Assert
            Assert.AreEqual(2, output);
        }

        [Test]
        public void Bizzer_When_qwqw_ReturnsNegative()
        {
            // Arrange
            var input = "qwqw";

            // Act
            int output = FizzBuzzer.FirstUnique(input);

            // Assert
            Assert.AreEqual(-1, output);
        }

        [Test]
        public void Bizzer_When_qw_Returns0()
        {
            // Arrange
            var input = "qw";

            // Act
            int output = FizzBuzzer.FirstUnique(input);

            // Assert
            Assert.AreEqual(0, output);
        }

        [Test]
        public void Bizzer_When_Empty_ReturnsNegative()
        {
            // Arrange
            var input = string.Empty;

            // Act
            int output = FizzBuzzer.FirstUnique(input);

            // Assert
            Assert.AreEqual(-1, output);
        }

        [Test]
        public void Bizzer_When_Null_ReturnsNegative()
        {
            // Arrange
            string input = null;

            // Act
            int output = FizzBuzzer.FirstUnique(input);

            // Assert
            Assert.AreEqual(-1, output);
        }

        ////
        [Test]
        public void UniqueCount_when_qwe_return_3()
        {
            string input = "qwe";
            int count = FizzBuzzer.getUniqueCount(input);
            Assert.AreEqual(3, count);
        }

        [Test]
        public void UniqueCount_when_qwertrewq_return_5()
        {
            string input = "qwertrewq";
            int count = FizzBuzzer.getUniqueCount("qwertrewq");
            Assert.AreEqual(5, count);
        }

        [Test]
        public void UniqueCount_when_null_return_0()
        {
            string input = null;
            int count = FizzBuzzer.getUniqueCount(input);
            Assert.AreEqual(0, count);
        }

        [Test]
        public void UniqueCount_when_empty_return_0()
        {
            string input = string.Empty;
            int count = FizzBuzzer.getUniqueCount(input);
            Assert.AreEqual(0, count);
        }

    }
}
