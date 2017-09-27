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
            string input = "pallida";
            Dictionary<char, int> output = new Dictionary<char, int>()
            {
                { 'p', 1 },
                { 'a', 2 },
                { 'l', 2},
                { 'i', 1 },
                { 'd', 1 }

            };
            Assert.AreEqual(output, countLetter.FromStringToDictionary(input));
        }
    }
}
