using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sum;

namespace SumTest
{
    [TestFixture]
    public class SumTestClass
    {
        SumClass sum = new SumClass();

        [Test]
        public void TestSumFunctionWithEmptyString()
        {
            List<int> input = new List<int>();
            int output = 0;
            Assert.AreEqual(output, sum.SumElementsOfList(input));
        }

        [Test]
        public void TestSumFunctionWithOneElement()
        {
            List<int> input = new List<int>() { 10 };
            int output = 10;
            Assert.AreEqual(output, sum.SumElementsOfList(input));
        }

        [Test]
        public void TestSumFunctionWithMultiplyElement()
        {
            List<int> input = new List<int>() { 1, 2, 3, 4, 5 };
            int output = 15;
            Assert.AreEqual(output, sum.SumElementsOfList(input));
        }

        [Test]
        public void TestSumFunctionWithNull()
        {
            List<int> input = null;
            int output = 0;
            Assert.AreEqual(output, sum.SumElementsOfList(input));
        }
    }
}
