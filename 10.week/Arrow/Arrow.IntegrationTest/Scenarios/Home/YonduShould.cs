using Arrow.IntegrationTest.TestFixture;
using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace Arrow.IntegrationTest
{
    [Collection("BaseCollection")]
    public class YonduShould
    {
        private TestContext Context;

        public YonduShould(TestContext context)
        {
            Context = context;
        }

        [Fact]
        public async Task ReturnOkStatus()
        {
            var response = await Context.Client.GetAsync("/yondu?distance=98.9&time=8");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnOkResponse()
        {
            var response = await Context.Client.GetAsync("/yondu?distance=98.9&time=8");
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"time\":8.0,\"distance\":98.9,\"speed\":791.2}", responseJson);
        }

        [Fact]
        public async Task ReturnErrorNoTime()
        {
            var response = await Context.Client.GetAsync("/yondu?distance=98.9");
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"error\":\"Please provide time and distance.\"}", responseJson);
        }

        [Fact]
        public async Task ReturnErrorNoDistance()
        {
            var response = await Context.Client.GetAsync("/yondu?time=8");
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"error\":\"Please provide time and distance.\"}", responseJson);
        }

        [Fact]
        public async Task ReturnErrorNoParameter()
        {
            var response = await Context.Client.GetAsync("/yondu");

            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}
