using Groot.IntegrationTest.TestFixture;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Groot.IntegrationTest.Scenarios.Guardian
{
    [Collection("BaseCollection")]
    public class GrootShould
    {
        private TestContext Context;

        public GrootShould(TestContext context)
        {
            //arrange
            Context = context;
        }

        [Fact]
        public async Task ReturnOkStatus()
        {
            var response = await Context.Client.GetAsync("/groot?message=somemessage");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnTranslation()
        {
            var response = await Context.Client.GetAsync("/groot?message=somemessage");
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"received\":\"somemessage\",\"response\":\"I am Groot!\"}", responseJson);
        }

        [Fact]
        public async Task ReturnError()
        {
            var response = await Context.Client.GetAsync("/groot");
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"error\":\"I am Groot!\"}", responseJson);
        }

        [Fact]
        public async Task ReturnNotFound()
        {
            var response = await Context.Client.GetAsync("/groot");

            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}
