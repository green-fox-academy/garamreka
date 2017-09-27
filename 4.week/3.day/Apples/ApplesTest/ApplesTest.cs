using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apples;

namespace ApplesTest
{
    [TestFixture]

    public class AppleTest
    {
        Apple apple = new Apple();

        [Test]
        public void TestApple_WhenApple_ThenApple()
        {
            //arrange

            //act
            string output = "apple";

            //assert
            Assert.AreEqual(output, apple.GetApple());
        }
    }
}
