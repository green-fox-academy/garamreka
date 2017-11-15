using CalorieTable.IntegrationTest.TestFixture;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalorieTable.IntegrationTest.Scenarios.Home
{
    [Collection("BaseCollection")]
    public class NoDatabaseShould
    {
        private TestContext Context;

        public NoDatabaseShould(TestContext context)
        {
            this.Context = context;
        }

        [Fact]
        public async Task ReturnResult()
        {
            var response = await Context.Client.GetAsync("/nodatabase");
            var responseString = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"test\":\"Test endpoint without database\"}", responseString);
        }
    }
}
