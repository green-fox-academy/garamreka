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
    public class GreeterShould
    {
        private TestContext Context;

        public GreeterShould(TestContext context)
        {
            //arrange
            Context = context;
        }

        [Fact]
        public async Task ReturnOkStatus()
        {
            //act
            var response = await Context.Client.GetAsync("/greeter?name=Petike&title=student");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnGreeting()
        {
            //act
            var response = await Context.Client.GetAsync("/greeter?name=Petike&title=student");
            string responseString = await response.Content.ReadAsStringAsync();

            //assert
            Assert.Equal("{\"welcome_message\":\"Oh, hi there Petike, my dear student!\"}", responseString);
        }

        [Fact]
        public async Task ReturnRequestTitle()
        {
            //act
            var response = await Context.Client.GetAsync("/greeter?name=Petike");
            string responseString = await response.Content.ReadAsStringAsync();

            //assert
            Assert.Equal("{\"error\":\"Please provide a title!\"}", responseString);
        }

        [Fact]
        public async Task ReturnRequestName()
        {
            //act
            var response = await Context.Client.GetAsync("/greeter?title=student");
            string responseString = await response.Content.ReadAsStringAsync();

            //assert
            Assert.Equal("{\"error\":\"Please provide a name!\"}", responseString);
        }
    }
}
