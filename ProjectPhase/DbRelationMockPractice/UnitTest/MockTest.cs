using DbRelationMockPractice.Controllers;
using DbRelationMockPractice.Repositories;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
    [TestFixture]
    class MockTest
    {
        [Test]
        public void ChangeNameRepoPhase()
        {
            var mockPracticeRepository = new Mock<IPracticeRepository>();
            var repo = new PracticeRepository(mockPracticeRepository.Object);

            mockPracticeRepository
                .Setup(a => a.ChangeName("Norbi", "Gyula"))
                .Returns("Gyula");

            Assert.AreEqual("Gyula", repo.ChangeName("Norbi", "Gyula"));
        }

        [Test]
        public void ChangeNameControllerPhase()
        {
            var mockPracticeRepository = new Mock<IPracticeRepository>();
            var controller = new HomeController(mockPracticeRepository.Object);
            
        }
    }
}
