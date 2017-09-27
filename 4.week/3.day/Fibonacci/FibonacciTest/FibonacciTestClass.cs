using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fibonacci;

namespace FibonacciTest
{
    [TestFixture]
    public class FibonacciTestClass
    {
        FibonacciClass fibonacciByIndex = new FibonacciClass();

        [Test]
        public void ComputeFibonacci_WhenIndexMoreThanTwo_ThenGiveElement()
        {
            double input = 5;
            double output = 3;
            Assert.AreEqual(output, fibonacciByIndex.ComputeFibonacci(input));
        }

        [Test]
        public void ComputeFibonacci_WhenIndexTwo_ThenOne()
        {
            double input = 2;
            double output = 1;
            Assert.AreEqual(output, fibonacciByIndex.ComputeFibonacci(input));
        }

        [Test]
        public void ComputeFibonacci_WhenIndexOne_ThenZero()
        {
            double input = 1;
            double output = 0;
            Assert.AreEqual(output, fibonacciByIndex.ComputeFibonacci(input));
        }

        [Test]
        public void ComputeFibonacci_WhenIndexLessThanOne_ThenBadRequest()
        {
            double input = -2;
            double output = 400;
            Assert.AreEqual(output, fibonacciByIndex.ComputeFibonacci(input));
        }
    }
}
