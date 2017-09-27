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
        public void TestSumFunction()
        {
            List<int> input = new List<int>() { 1, 2, 3, 4, 5 };

            int output = 15;

            Assert.AreEqual(output, sum.SumElementsOfList(input));
        }
    }
}
