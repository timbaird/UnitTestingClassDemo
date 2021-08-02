using System;
using Xunit;
using ClassLibrary;
using System.Collections.Generic;

namespace UnitTests
{
    public class MyMathTests
    {
        [Fact]
        public void MultiplyTest()
        {
            // Arrange - set the test up
            MyMath m = new MyMath();
            double n1 = 6;
            double n2 = 7;
            double expected = 42;

            // Act -  call the method to be tested
            double result = m.Multiply(n1, n2);

            // Assert - check is the answer is correct
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SubtractTest()
        {
            // Arrange - set the test up
            MyMath m = new MyMath();
            int from = 12;
            int subtract = 5;
            int expected = 7;

            // Act -  call the method to be tested
            int result = m.Subtract(from, subtract);

            // Assert - check is the answer is correct
            Assert.Equal(expected, result);
        }

      // [InlineData(int.MinValue, -1, int.MaxValue)]

        [Theory]
        [InlineData(10, 2, 8)]
        [InlineData(-4, 6, -10)]
        [InlineData(51, 0, 51)]
        [InlineData(2, 2, 0)]
        [InlineData(67, 34, 33)]
        public void SubtractTestTheory(int from, int subtract, int expected)
        {
            // Arrange - set the test up
            MyMath m = new MyMath();

            // Act -  call the method to be tested
            int result = m.Subtract(from, subtract);

            // Assert - check is the answer is correct
            Assert.Equal(expected, result);
        }   


        [Fact]
        public void DivideTestNormal()
        {
            MyMath m = new MyMath();
            double numerator = 35;
            double denominator = 7;
            double expected = 5;

            // Act -  call the method to be tested
            double result = m.Divide(numerator, denominator);

            // Assert - check is the answer is correct
            Assert.Equal(expected, result);
        }

        [Fact]
        public void DivideTestZero()
        {
            // Arrange - set the test up
            MyMath m = new MyMath();
            double num = 35;
            double den = 0;
            
            // Act -  call the method to be tested
            
            // Assert - check is the answer is correct
            Assert.Throws<ZeroDivException>(() => m.Divide(num, den));
        }

        [Fact]
        public void AddTest()
        {
            // Arrange - set the test up
            MyMath m = new MyMath();
            List<int> n = new List<int>{2,5,7,19,3,-4};
            int expected = 32;

            // Act -  call the method to be tested
            int result = m.Add(n);

            // Assert - check is the answer is correct
            Assert.Equal(expected, result);
        }

    }
}
