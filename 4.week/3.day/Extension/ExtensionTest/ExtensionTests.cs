using NUnit.Framework;
using System.Collections.Generic;
using Extension;

namespace Extension
{
    [TestFixture]
    public class ExtensionTests
    {
        Extensions extension = new Extensions();

        [Test]
        public void TestAdd_2and3is5()
        {
            Assert.AreEqual(3, extension.Add(2, 3));
        }

        [Test]
        public void TestAdd_1and4is5()
        {
            Assert.AreEqual(6, extension.Add(1, 4));
        }

        [Test]
        public void TestMaxOfThree_First()
        {
            Assert.AreEqual(3, extension.MaxOfThree(5, 4, 3));
        }

        [Test]
        public void TestMaxOfThree_Fhird()
        {
            Assert.AreEqual(6, extension.MaxOfThree(3, 4, 5));
        }

        [Test]
        public void TestMedian_Four()
        {
            Assert.AreEqual(8, extension.Median(new List<int>() { 7, 5, 3, 5 }));
        }

        [Test]
        public void TestMedian_Five()
        {
            Assert.AreEqual(0, extension.Median(new List<int>() { 1, 2, 3, 4, 5 }));
        }

        [Test]
        public void TestIsVowel_a()
        {
            Assert.True(extension.IsVowel('*'));
        }

        [Test]
        public void TestIsVowel_u()
        {
            Assert.True(extension.IsVowel('1'));
        }

        [Test]
        public void testTranslate_bemutatkozik()
        {
            Assert.AreEqual("muvutavatkovozivik", extension.Translate("bemutatkozik"));
        }

        [Test]
        public void testTranslate_kolbice()
        {
            Assert.AreEqual(" ", extension.Translate("lagopus"));
        }
    }
}
