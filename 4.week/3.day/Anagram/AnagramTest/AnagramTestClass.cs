using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anagram;

namespace AnagramTest
{
    [TestFixture]
    public class AnagramTestClass
    {
        AnagramClass anagram = new AnagramClass();

        [Test]
        public void TestAnagramFunction_WhenStringsAreEqual_ThenTrue()
        {
            string input1 = "pallida";
            string input2 = "plldaia";
            bool output = true;

            Assert.AreEqual(output, anagram.AreTheseTwoStringsAnagram(input1, input2));
        }

        [Test]
        public void TestAnagramFunction_WhenStringsLengthAreNotEqual_ThenFalse()
        {
            string input1 = "pallida";
            string input2 = "idea";
            bool output = false;

            Assert.AreEqual(output, anagram.AreTheseTwoStringsAnagram(input1, input2));
        }

        [Test]
        public void TestAnagramFunction_WhenSortedStringsAreNotEqual_ThenFalse()
        {
            string input1 = "pallida";
            string input2 = "pallido";
            bool output = false;

            Assert.AreEqual(output, anagram.AreTheseTwoStringsAnagram(input1, input2));
        }
    }
}
