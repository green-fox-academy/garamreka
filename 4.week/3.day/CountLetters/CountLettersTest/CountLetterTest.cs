using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountLetters;

namespace CountLettersTest
{
    [TestFixture]
    public class CountLetterTest
    {
        CountLetter countLetter = new CountLetter();

        [Test]
        public void FromStringToDictionary_WhenSameChars_ThenSameKeys()
        {
            string input = "non ho pallida idea";
            Dictionary<char, int> output = new Dictionary<char, int>()
            {
                { 'n', 2 },
                { 'o', 2 },
                { ' ', 3 },
                { 'h', 1 },
                { 'p', 1 },
                { 'a', 3 },
                { 'l', 2 },
                { 'i', 2 },
                { 'd', 2 },
                { 'e', 1 }
            };
            Assert.AreEqual(output, countLetter.FromStringToDictionary(input));
        }
    }
}
