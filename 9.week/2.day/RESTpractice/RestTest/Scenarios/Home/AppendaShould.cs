using RestTest.TestFixtures;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Rest.IntegrationTests.Scenarios.Home
{
    [Collection("BaseCollection")]
    public class AppendaShould
    {
        private TestContext Context;

        public AppendaShould(TestContext context)
        {
            //arrange
            Context = context;
        }

        [Fact]
        public async Task ReturnOkStatus()
        {
            //act
            var response = await Context.Client.GetAsync("/appenda/cic");
            string responseJson = await response.Content.ReadAsStringAsync();

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnAppendaCic()
        {
            //act
            var response = await Context.Client.GetAsync("/appenda/cic");
            string responseJson = await response.Content.ReadAsStringAsync();

            //assert
            Assert.Equal("{\"appended\":\"cica\"}", responseJson);
        }

        [Fact]
        public async Task ReturnAppendaErrorNotFound()
        {
            //act
            var response = await Context.Client.GetAsync("/appenda");
            string responseJson = await response.Content.ReadAsStringAsync();

            //assert
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}
